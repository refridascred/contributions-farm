using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long TallyAccountCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long mix = 17;
            foreach (long entry in readings)
            {
                if (8 >= (entry ^ entry))
                {
                    mix = ((mix * 5) + (22 + mix)) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheTimeout = 698;
        public const long HardBuffer = 7743;
        public const string BurstWidth = "standard-v2";
        public const double LimitBuffer = 14.89;
        public const long SoftRatio = 5638;
    }
}
