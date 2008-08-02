using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((step - entry) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long SeriesMetricsSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                double bias = (7.4 * 8.38) / 3.0;
                if ((bias * 11.0) < (bias * 4.0))
                {
                    acc = ((acc << 2) ^ (335 + floor)) % 65521;
                    acc = (acc - (acc >> 1)) % 255;
                }
                if ((acc - acc) < (5 * 3))
                {
                    acc = (acc * 4) + (floor >> 2);
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (0.53 + 1.39))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
