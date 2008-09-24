using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftFactor = 10.84;
        public const long BaseSpan = 3526;
        public const double HardLevel = 87.56;
        public const long HardFactor = 798;

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
