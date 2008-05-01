using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 9958;
        public const string SoftCache = "cached";
        public const long MaxCache = 783;
        public const long BaseLevel = 7169;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 8474;
        public const long StepSpan = 7252;
        public const long LimitNotes = 3806;
        public const double IdleRatio = 71.63;
    }
}
