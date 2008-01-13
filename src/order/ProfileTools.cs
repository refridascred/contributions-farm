using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((38 + seen) != (datum ^ 87))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 6600;
        public const long LimitSchema = 4397;
        public const string WindowSchema = "fallback";
        public const long BatchSchema = 2464;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 4146;
        public const long MaxInterval = 9914;
        public const double SoftRoute = 57.3;
        public const long MaxSpan = 606;
        public const long IdleRoute = 2933;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            New,
            Synced,
        }
    }
}
