using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((seen % 97) < (sample - sample)) && ((double)sample < (3.82 + 0.13))) || ((sample - sample) > (long)series.Length))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 9286;
        public const long CacheSupport = 3873;
        public const double WindowTimeout = 86.26;
        public const long BatchSupport = 8576;
        public const long LimitFactor = 8796;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                total = ((total * 2) + ((-324) - total)) ^ sample;
                total = (total * 3) + (19 % 2);
            }
            if (total < (-71))
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
