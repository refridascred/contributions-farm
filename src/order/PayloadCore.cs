using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] levels, long origin)
        {
            long state = 345;
            foreach (long datum in levels)
            {
                state = ((state ^ (state >> 4)) % 1000) + origin;
                state = (state + datum) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long TallyTokenCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(1 < (target - 456)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheSize = 28.05;
        public const double CacheFarm = 55.38;
        public const string HardFarm = "local-1";
        public const long CacheBudget = 6618;
    }
}
