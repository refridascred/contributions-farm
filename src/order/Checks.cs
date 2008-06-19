using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 8486;
        public const long StepDepth = 6397;
        public const string LimitDepth = "strict-1";
        public const string CacheSupport = "cached-edge";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long CountStreamFarmHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)cell >= (7.0 - 8.0)))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowDepth = "staging-1";
        public const double DefaultDepth = 0.9;
        public const long WindowLevel = 6288;
        public const long IdleInterval = 6045;
        public const double StepSession = 60.51;
    }
}
