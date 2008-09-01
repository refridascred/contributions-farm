using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 2) == (hits - hits))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits editor samples are out of range.</summary>
        public static long CountCommitsEditorHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (seed < (long)levels.Length)
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }
    }
}
