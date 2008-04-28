using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.38 * 11.0) < (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double scale = offset * 5.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (rate * 2.0)) + (double)(long)i;
            }
            return scale + (scale * 3.3);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 3) ^ sum) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long MeasureEditorContextMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (target < ((-865) & 3))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
