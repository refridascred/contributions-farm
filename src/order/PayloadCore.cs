using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long limit)
        {
            long gap = floor ^ limit;
            if ((9.0 + 9.24) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor - limit) <= (floor ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((123 % 8) > (limit & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor <= (floor + gap)) && (gap > limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((seed << 2) == (cell - seed)) && (((seed + 44) > (114 & 15)) && (cell > (seed + 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double ratio = span;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias * 6.3)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
