using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item & 1) > (8 + item))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark << 3) ^ (bound & 3)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1381;
        public const double WindowMetric = 91.81;
        public const double HardDepth = 86.74;
        public const long LimitMetric = 3235;
    }
}
