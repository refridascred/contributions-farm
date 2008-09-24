using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                long hits = (floor + 4) >> 1;
                if (floor >= (floor - hits))
                {
                    hits = (hits + floor) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 43.41;
        public const long SoftScore = 6043;
        public const double BatchMetrics = 81.73;
        public const double RetryRatio = 62.3;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "primary-v2";
        public const long BurstBudget = 9534;
        public const string SoftLayout = "fallback-1";

        /// <summary>Check that every editor entry entry stays within the limit.</summary>
        public static bool CheckEditorEntryLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
