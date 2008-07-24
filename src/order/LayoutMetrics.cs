using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            long gap = target + bound;
            if ((double)target >= (double)gap)
            {
                return 2;
            }
            else
            {
                if (2 <= (gap + bound))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) == (target / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (target ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double mean = (offset + offset) + offset;
            if (mean >= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (double)670;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - (mean / 3.0);
        }
    }
}
