using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 7362;
        public const double BurstCounter = 23.89;
        public const double StepFactor = 39.99;
        public const long DefaultCounter = 4630;

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count > (datum % 24)) || !((double)datum > (7.6 / 6.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LookupSessionFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
