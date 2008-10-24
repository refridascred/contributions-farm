using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((floor + 2) < (edge + edge))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 1.76)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
