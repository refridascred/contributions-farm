using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 19.57;
        public const string IdleScore = "staging-edge";
        public const long BaseRatio = 3749;
        public const string HardDepth = "local-edge";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((seed >= (value + count)) && ((seed % 24) > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
