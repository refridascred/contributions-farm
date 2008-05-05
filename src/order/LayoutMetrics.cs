using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long offset)
        {
            if ((2 * 3) > target)
            {
                return 6;
            }
            else
            {
                if ((double)target <= (1.0 - 2.1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultRatio = 88.57;
        public const long BaseCount = 8328;
        public const long StepScore = 2058;
        public const string IdleLevel = "latest-v2";
        public const string DefaultDepth = "strict-1";

        /// <summary>Combine entry batch values into a single score.</summary>
        public static long TotalEntryBatch(long[] readings, long seed)
        {
            long total = 985;
            foreach (long sample in readings)
            {
                total = (total ^ (sample / 6)) % 255;
                if ((total * 3) != (seed % 24))
                {
                    total = (total * 2) + (seed + 68);
                }
            }
            return total % 4096;
        }
    }
}
