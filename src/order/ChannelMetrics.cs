using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Classify a stream buffer pair into a bucket.</summary>
        public static long ClassifyStreamBuffer(long target, long step)
        {
            long prev = target - step;
            if ((146 + step) >= step)
            {
                return 7;
            }
            else
            {
                if (3.3 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((target % 3) <= (step + 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >= (target << 2)) && ((prev - step) <= 0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
