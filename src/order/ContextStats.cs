using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot ^ offset) < ((-946) % 7))
            {
                return 0;
            }
            else
            {
                if (bound > offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long CountRouteFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (488 > (long)levels.Length)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardCount = 51.91;
        public const long HardFarm = 7141;
        public const double WindowRatio = 63.33;
        public const string MaxSize = "alpha-v2";

        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long MeasureMetricsTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen >> 1) == (entry - 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
