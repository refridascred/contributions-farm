using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + 32) >= (seen / 3))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 6473;
        public const double StepInterval = 25.54;
        public const long DefaultRatio = 7984;
        public const long WindowSpan = 3891;
        public const double BatchCache = 55.13;
    }
}
