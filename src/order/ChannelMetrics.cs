using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3044;
        public const long RetryTimeout = 4285;
        public const long DefaultBatches = 2526;
        public const long MinScore = 6769;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long limit2)
        {
            long prev = limit - limit2;
            if (prev < (limit * 5))
            {
                return 0;
            }
            else
            {
                if ((double)limit > (8.4 * 0.55))
                {
                    return 4;
                }
                else
                {
                    if (!((12.0 - 2.6) >= (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit == (double)prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long ClassifyBufferCommand(long floor, long offset)
        {
            long bound = floor + offset;
            if ((double)bound <= 1.66)
            {
                return 5;
            }
            else
            {
                if (14 >= (bound / 2))
                {
                    return 6;
                }
                else
                {
                    if ((offset + floor) > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
