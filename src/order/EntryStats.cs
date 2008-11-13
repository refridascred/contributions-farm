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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            if (!(5.2 >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((origin ^ origin2) <= (origin / 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count stats batches pairs that satisfy a relation.</summary>
        public static long PairStatsBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
