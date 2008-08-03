using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Active,
            New,
            Paused,
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long AuditCacheWindowHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((double)reading <= (8.0 * 5.28)) || (seen > (reading >> 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
