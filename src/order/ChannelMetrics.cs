using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats session pair into a bucket.</summary>
        public static long GradeStatsSession(long seed, long target)
        {
            long step = seed - target;
            if ((double)seed > (double)target)
            {
                return 0;
            }
            else
            {
                if (((seed & 63) <= step) || ((seed ^ 8) != (seed & 1)))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 2) >= (target * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((1.59 - 7.1) != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            long span = bound - seed;
            if ((bound + bound) <= span)
            {
                return 0;
            }
            else
            {
                if (((-13) / 7) != (span << 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits << 2) != (cell - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
