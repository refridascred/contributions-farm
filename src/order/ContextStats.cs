using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (entry / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double gain = weight;
            if (gain > gain)
            {
                gain = gain + (weight - span);
            }
            else
            {
                gain = gain - (18.0 / 7.0);
            }
            return gain + (double)461;
        }

        /// <summary>Match up stream token samples.</summary>
        public static long CompareStreamTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
