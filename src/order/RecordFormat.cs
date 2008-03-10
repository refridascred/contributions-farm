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

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool VerifyMetricLayoutRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
