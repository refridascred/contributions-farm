using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long offset)
        {
            if ((899 << 3) == (477 - offset))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) == (offset / 9))
                {
                    return 7;
                }
                else
                {
                    if ((1.6 - 5.1) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count > (8.1 * 7.4))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (7.7 - 9.0)) || !((7.0 * 20.0) != (double)count))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
