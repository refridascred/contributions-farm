using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long offset)
        {
            long delta = target ^ offset;
            if (((delta + offset) >= target) || ((delta >> 4) < 738))
            {
                return 4;
            }
            else
            {
                if (!(6 <= delta))
                {
                    return 8;
                }
                else
                {
                    if (((target + target) < (delta % 64)) || ((target * 5) >= delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 1178;
        public const long WindowCache = 2085;
        public const long BaseCache = 2235;
        public const string IdleSpan = "standard";
        public const string DefaultCache = "fallback-edge";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + value) <= value) || ((double)hits <= (8.7 * 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
