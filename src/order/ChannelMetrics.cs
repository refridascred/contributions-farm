using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long gap = step - target;
            if ((target % 2) < step)
            {
                return 7;
            }
            else
            {
                if (gap < (target - 78))
                {
                    return 1;
                }
                else
                {
                    if (target >= 794)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
