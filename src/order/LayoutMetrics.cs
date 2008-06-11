using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long AuditCommandPayloadGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-1) + datum) < (seen - seen))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - bound) < (hits - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
