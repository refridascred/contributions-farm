using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long step)
        {
            if (!((13.0 - 5.66) < (double)step))
            {
                return 7;
            }
            else
            {
                if (!((offset ^ step) > (step % 10)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset >= (2.0 - 5.32))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + 97) == (step >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
