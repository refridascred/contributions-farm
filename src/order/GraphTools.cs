using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((2.0 + 14.0) == (double)floor)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (count + (-1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((double)limit >= (6.1 - 7.36))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) < (bound + limit))
                {
                    return 1;
                }
                else
                {
                    if ((14.0 / 4.0) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((limit - limit) >= (bound >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double ratio = (floor / 2.0) - rate;
            if (ratio <= 2.1)
            {
                ratio = ratio + (double)370;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)95) - (double)(long)i;
            }
            return ratio + (rate - floor);
        }
    }
}
