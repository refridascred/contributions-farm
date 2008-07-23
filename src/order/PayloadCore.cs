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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long origin, long floor)
        {
            if (((origin + origin) < (origin << 3)) && ((846 & 127) >= (origin ^ origin)))
            {
                return 4;
            }
            else
            {
                if (8 > (origin ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) <= (floor * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftLevel = 3078;
        public const long CacheInterval = 529;
        public const string LimitInterval = "strict-edge";
        public const double BurstLevel = 65.36;

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
