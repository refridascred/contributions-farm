using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches > origin)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - ((long)i + mix);
                if (((long)i - mix) > (mix >> 1))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) > (reading ^ reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
