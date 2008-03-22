using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double ratio, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - (double)912;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long TallyRouteNotesMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 3) == (seed - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool ValidateSchemaFarmRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits % 3) >= origin)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 7361;
        public const long CacheSupport = 5422;
        public const long IdleFactor = 8855;
        public const double LimitScore = 43.27;
    }
}
