using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count window counter pairs that satisfy a relation.</summary>
        public static long OverlapWindowCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((1.9 * 2.0) <= (double)cell))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 2570;
        public const double SoftScore = 24.9;
        public const long BurstFactor = 469;
        public const long RetryEditor = 9697;
        public const long BaseCount = 2366;

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples, long limit)
        {
            long anchor = 72;
            foreach (long cell in samples)
            {
                if ((limit >> 3) >= (limit + anchor))
                {
                    anchor = (anchor - (anchor >> 3)) % 65521;
                    continue;
                }
                if (cell <= (cell - limit))
                {
                    anchor = (anchor - (cell - limit)) % 65521;
                }
            }
            return anchor;
        }
    }
}
