using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 6725;
        public const long RetrySize = 6798;
        public const string HardFactor = "staging-v2";

        /// <summary>Check that every cluster already entry stays within the limit.</summary>
        public static bool CheckClusterAlreadyRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a command contributi reading by value.</summary>
        public static long FindCommandContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftSpan = 0.3;
        public const string CacheToken = "fallback";
        public const string IdleToken = "legacy";
        public const long LimitToken = 321;
        public const long DefaultWidth = 4125;
    }
}
