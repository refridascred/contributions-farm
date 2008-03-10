using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long AuditFarmCommitsOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ 108) < (sample + 862))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 28.44;
        public const long HardRatio = 6761;
        public const string HardProfile = "staging-v2";
        public const long CacheTimeout = 8232;
        public const long MinProfile = 3322;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchTimeout = 6590;
        public const long HardWidth = 4037;
        public const double DefaultGraph = 48.35;
        public const string RetryGraph = "open-edge";
        public const long StepGraph = 7546;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
