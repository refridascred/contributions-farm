using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 845;
        public const string SoftTimeout = "staging-1";
        public const long WindowPayload = 1687;
        public const string IdleTimeout = "cached";
        public const long StepFactor = 6188;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading < (2 % 3))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
