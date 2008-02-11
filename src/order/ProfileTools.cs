using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "staging-edge";
        public const double MinRatio = 2.59;
        public const long BurstLayout = 2399;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((double)prev > (2.5 - 3.7))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) == (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items, long limit)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (((8.26 * 7.9) != (double)sum) && (sum < (limit >> 4)))
                {
                    sum = ((sum ^ limit) % 97) ^ datum;
                }
                sum = (sum ^ sum) % 1000;
            }
            return sum;
        }
    }
}
