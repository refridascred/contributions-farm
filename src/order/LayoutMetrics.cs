using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next already farm value from a seed.</summary>
        public static long StepAlreadyFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((12.0 + 17.0) < (double)floor)
                {
                    score = score + ((long)i - score);
                    continue;
                }
                if ((double)floor <= 9.4)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (hits % 3))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = ((acc ^ limit) % 4096) ^ item;
            }
            return acc;
        }
    }
}
