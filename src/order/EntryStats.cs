using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 2) ^ (seed >> 3);
                anchor = (anchor - (anchor & 7)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many farm route samples are out of range.</summary>
        public static long AuditFarmRouteHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((bound + hits) != (hits + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long step)
        {
            if ((seed * 2) <= step)
            {
                return 4;
            }
            else
            {
                if (((seed & 127) < step) || ((step % 16) <= (seed * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) != (step + (-593))) || ((step << 3) <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 2972;
        public const string MinSpan = "latest";
        public const long MinCounter = 382;
        public const double LimitSize = 89.58;
        public const long BatchInterval = 5056;
    }
}
