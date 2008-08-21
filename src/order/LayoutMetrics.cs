using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long TallyMetricTokenMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches >= (matches % 24)) && ((matches * 2) >= (item << 3))))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = (acc ^ offset) ^ (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Failed,
            Stale,
        }
    }
}
