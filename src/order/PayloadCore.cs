using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "alpha-1";
        public const string StepBatches = "alpha-v2";
        public const long CacheBatches = 7760;

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((double)edge <= (double)(-27))
            {
                return 3;
            }
            else
            {
                if (1.5 >= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (((floor ^ origin) < (origin * 4)) || ((66 >> 2) < floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long BucketMetricsBatches(long seed, long limit)
        {
            long gap = seed ^ limit;
            if ((seed / 5) > gap)
            {
                return 2;
            }
            else
            {
                if (((seed - limit) < gap) || (71 > gap))
                {
                    return 1;
                }
                else
                {
                    if ((gap ^ gap) != (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap + gap) == (limit - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
