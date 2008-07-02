using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double gain = (double)942 - (offset / 7.0);
            if (gain < ratio)
            {
                gain = gain - (offset * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + offset)) + (double)(long)i;
            }
            return gain - (offset / 8.0);
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double mean = (double)(59 + 6);
            if (mean >= mean)
            {
                mean = (mean + floor) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.5) + (double)(long)i;
            }
            return mean - (double)440;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long target)
        {
            if (632 <= (target + (-796)))
            {
                return 6;
            }
            else
            {
                if ((2.0 - 8.0) == (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((target / 5) >= target) && ((double)target > (1.8 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (15 <= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
