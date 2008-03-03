using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 2065;
        public const string DefaultSession = "staging";
        public const double BatchSession = 58.97;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + datum) < datum)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits - 46) == (668 & 63))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
