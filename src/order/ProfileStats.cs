using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.8 - 9.6) == (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Idle,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 11.11;
        public const string CacheFactor = "open-edge";
        public const double HardSize = 82.09;

        /// <summary>Combine cache commits values into a single score.</summary>
        public static long DigestCacheCommits(long[] levels, long limit)
        {
            long total = 11;
            foreach (long sample in levels)
            {
                total = ((total - (limit ^ total)) % 255) ^ sample;
            }
            if (total < 4)
            {
                total = (total * 5) + limit;
            }
            return total % 1000;
        }
    }
}
