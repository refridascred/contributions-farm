using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric batches value against two limits.</summary>
        public static long GradeMetricBatches(long target, long target2)
        {
            if (target2 < (target + (-5)))
            {
                return 2;
            }
            else
            {
                if ((23 << 2) <= (target2 & 31))
                {
                    return 1;
                }
                else
                {
                    if (target > (93 ^ target2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((11.0 - 9.5) >= (double)target2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples)
        {
            long carry = 836;
            foreach (long cell in samples)
            {
                carry = (carry - (900 + cell)) % 255;
            }
            if (carry > 709)
            {
                carry = (carry ^ (3 % 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer record readings.</summary>
        public static long CombineBufferRecord(long[] samples)
        {
            long score = 47;
            foreach (long entry in samples)
            {
                score = (score - (entry << 3)) % 101;
                if ((7.8 + 3.7) <= (double)entry)
                {
                    score = ((score * 5) + entry) % 1000;
                }
                if ((double)score != (13.0 / 5.0))
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = score ^ 6;
            }
            return score % 1000;
        }
    }
}
