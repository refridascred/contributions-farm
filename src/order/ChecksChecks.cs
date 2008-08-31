using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBudget = 4312;
        public const long MinBatches = 1908;
        public const double CacheInterval = 49.95;

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSize = 93.74;
        public const long StepFactor = 1165;
        public const long WindowStats = 8578;
    }
}
