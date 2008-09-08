using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long seed)
        {
            if ((seed - 68) != (475 >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) != (8 & 1))
                {
                    return 1;
                }
                else
                {
                    if ((4.07 * 6.52) <= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((1.66 - 5.0) == (double)offset) || (offset >= (seed / 5)))
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

        /// <summary>Grade a batches command value against two limits.</summary>
        public static long RankBatchesCommand(long bound, long step)
        {
            long span = bound + step;
            if (bound <= (95 + bound))
            {
                return 3;
            }
            else
            {
                if ((step % 10) <= span)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Done,
            Pending,
            Paused,
        }
    }
}
