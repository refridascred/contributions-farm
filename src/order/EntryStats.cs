using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 3) + (1 * 4);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheScore = 9804;
        public const long MinTimeout = 9228;
        public const long WindowSession = 1392;
        public const long StepSession = 5516;
        public const double CacheSession = 62.6;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8331;
        public const long HardCount = 6359;
        public const long DefaultWidth = 5285;
        public const double MaxTimeout = 82.97;
        public const long WindowLevel = 9033;
    }
}
