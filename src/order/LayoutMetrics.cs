using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((8 + 68) > (reading & 127))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 5337;
        public const long WindowNotes = 7272;
        public const double BatchNotes = 52.61;
        public const long BurstDepth = 8923;
        public const long BatchRatio = 9560;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable-1";
        public const double BaseFarm = 53.28;
        public const long HardFarm = 2241;
    }
}
