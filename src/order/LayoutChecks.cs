using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long offset)
        {
            if ((5.0 - 9.22) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound - offset) == (18 - bound))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Done,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Draft,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Paused,
            Retry,
            Synced,
            New,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
