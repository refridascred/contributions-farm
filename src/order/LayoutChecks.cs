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

        /// <summary>Check that every token order entry stays within the limit.</summary>
        public static bool VerifyTokenOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheTimeout = 698;
        public const long HardBuffer = 7743;
        public const string BurstWidth = "standard-v2";
        public const double LimitBuffer = 14.89;
        public const long SoftRatio = 5638;
    }
}
