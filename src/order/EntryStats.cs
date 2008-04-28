using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series)
        {
            long sum = 304;
            foreach (long cell in series)
            {
                sum = (sum + cell) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (672 * 5);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1674;
        public const long BurstCount = 7890;
        public const string RetrySize = "stable-edge";
        public const double CacheProfile = 90.58;

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long OverlapWindowStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
