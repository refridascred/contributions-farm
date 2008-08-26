using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double mean = (double)(30 << 3);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (double)457) - (double)(long)i) + bias;
            }
            return mean + (bias2 - bias2);
        }

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long CountFormatProfileHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count >= (count >> 2)) && ((entry << 2) != (entry & 15)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((8.69 * 4.6) != (double)datum)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
