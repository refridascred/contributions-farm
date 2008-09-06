using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Stale,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long GradeChecksBatches(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (((delta % 7) != (seed - 103)) || (3 < (seed + offset)))
            {
                return 6;
            }
            else
            {
                if (((delta >> 1) < (delta + seed)) && (offset < (delta - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + offset) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long seed)
        {
            long slot = target + seed;
            if ((slot / 8) != (target >> 1))
            {
                return 7;
            }
            else
            {
                if (seed < (slot - 36))
                {
                    return 4;
                }
                else
                {
                    if (((0.1 + 13.0) == (double)target) || ((target ^ target) <= 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (double)slot)
                        {
                            return 0;
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
