using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double bias = (rate * 7.77) - (offset * 5.4);
            if (bias < (rate / 4.0))
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - 5.6;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long floor)
        {
            long sum = 78;
            foreach (long value in data)
            {
                sum = (sum << 3) ^ (floor & 7);
                sum = ((sum << 2) ^ (sum % 60)) % 255;
                if ((value / 4) >= floor)
                {
                    sum = (sum << 2) ^ 2;
                }
                if ((sum + value) < (827 >> 5))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > (limit << 2))
            {
                return 5;
            }
            else
            {
                if (!((double)offset == (15.0 - 6.76)))
                {
                    return 2;
                }
                else
                {
                    if (1.2 >= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
