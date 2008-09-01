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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((8.57 + 1.7) >= (double)limit) || ((limit >> 5) != (136 + limit)))
                {
                    result = (result - result) % 1000;
                }
                result = result + result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
