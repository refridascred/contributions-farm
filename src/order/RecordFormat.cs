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

        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 2101;
        public const double CacheContext = 62.9;
        public const string BurstWidth = "stable-1";

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 7356;
        public const long DefaultRatio = 6810;
        public const long StepFactor = 1352;
        public const string DefaultChecks = "strict-1";
        public const long SoftLevel = 8112;

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
