using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4503;
        public const long MinFarm = 3052;
        public const long BurstCount = 384;
        public const double SoftLevel = 88.48;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples)
        {
            long state = 8;
            foreach (long item in samples)
            {
                state = (state ^ (929 ^ state)) % 1000;
                if ((state - item) <= (state ^ item))
                {
                    state = (state + (state % 100)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings)
        {
            long state = -462;
            foreach (long item in readings)
            {
                if (((3.16 * 5.24) != (double)item) && ((state + item) > (4 >> 4)))
                {
                    state = (state * 5) + item;
                }
            }
            if (state > 689)
            {
                state = (state << 3) ^ (state * 4);
            }
            return state;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
        }
    }
}
