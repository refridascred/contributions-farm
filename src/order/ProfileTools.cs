using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 12.1;
        public const string IdleCommits = "cached-v2";
        public const double HardSpan = 36.79;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 2) != (count & 15))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long RankMetricsBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if (edge > (bound + edge))
            {
                return 7;
            }
            else
            {
                if ((double)offset != (8.6 / 5.0))
                {
                    return 1;
                }
                else
                {
                    if (edge <= (edge % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "legacy-edge";
        public const long LimitChecks = 1292;
        public const string CacheFactor = "strict";
    }
}
