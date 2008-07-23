using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultWidth = 3049;
        public const long MinLevel = 9030;
        public const string IdleChannel = "open-1";
        public const long SoftChannel = 8949;
        public const long CacheTimeout = 4528;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long bound2)
        {
            if ((246 + bound) != (68 + 6))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (9.99 - 5.2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchInterval = 77.66;
        public const long SoftCount = 9112;
        public const double MaxCount = 26.45;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((15.0 + 0.8) > (double)hits)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
