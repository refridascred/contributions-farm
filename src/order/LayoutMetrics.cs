using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long target)
        {
            long span = step + target;
            if ((step & 255) >= (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((0.2 * 8.95) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((0.6 - 5.9) != (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
