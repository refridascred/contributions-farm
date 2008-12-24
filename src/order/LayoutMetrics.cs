using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            long next = origin + target;
            if (((target - next) < target) || ((37 << 2) > next))
            {
                return 4;
            }
            else
            {
                if ((origin / 3) >= target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - (anchor ^ seed);
                anchor = (anchor - seed) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((-80) < (86 - count)) && ((double)bound > (1.3 / 6.0)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
