using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((8.9 * 1.0) != (double)tally) && !(value >= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long MeasureWindowRouteHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)target <= (5.4 * 1.98))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)step >= (15.0 + 13.0))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 5647;
        public const long CacheWidth = 9509;
        public const string MinCache = "stable-1";
        public const long LimitRatio = 4042;
        public const string BatchCache = "cached";
    }
}
