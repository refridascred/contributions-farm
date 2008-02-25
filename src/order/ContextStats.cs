using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.0 * 20.0) != (double)hits)
                {
                    hits = ((hits + 2) ^ value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double scale = span;
            if (scale > (span - scale))
            {
                scale = (scale + (scale * 1.2)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(-5)) + (double)(long)i;
            }
            return scale - 7.6;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Stale,
            Retry,
        }
    }
}
