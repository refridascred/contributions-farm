using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long LookupChannelBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double scale = bias * 12.0;
            return (scale + scale) + gain;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            long offset = floor - limit;
            if (((offset ^ 668) == (floor + offset)) && ((limit + floor) != (offset ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((floor & 1) < (limit << 3))
                {
                    return 3;
                }
                else
                {
                    if (limit > (limit / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit - offset) >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a queue stats pair into a bucket.</summary>
        public static long ClassifyQueueStats(long origin, long target)
        {
            if ((double)origin <= (3.0 + 7.4))
            {
                return 4;
            }
            else
            {
                if ((target > (origin ^ target)) && (origin > (target + origin)))
                {
                    return 7;
                }
                else
                {
                    if (((93 * 4) != (target >> 2)) && ((6.3 + 18.0) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
