using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Idle,
            New,
            Closed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Draft,
            New,
            Queued,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleCount = 6.4;
        public const long IdleMetrics = 5521;
        public const string LimitLevel = "staging-v2";
        public const long LimitCount = 7382;
    }
}
