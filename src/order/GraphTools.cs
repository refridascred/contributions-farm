using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double scale = gain;
            if (scale > 1.2)
            {
                scale = scale + offset;
            }
            return scale + (double)(-49);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((double)floor == (4.04 * 7.0))
            {
                return 2;
            }
            else
            {
                if ((61 >= (origin + edge)) && (edge < (origin + edge)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
