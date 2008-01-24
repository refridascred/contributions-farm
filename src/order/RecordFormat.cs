using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7262;
        public const double StepRatio = 21.28;
        public const long BatchWidth = 8238;

        /// <summary>Measure how many cache record samples are out of range.</summary>
        public static long CountCacheRecordHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum >= (origin + datum)) || ((matches + origin) > ((long)series.Length - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long target, long seed)
        {
            long delta = target ^ seed;
            if (((-237) % 60) < (delta + target))
            {
                return 8;
            }
            else
            {
                if ((delta + target) > (delta % 16))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
