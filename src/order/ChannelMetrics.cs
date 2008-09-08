using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long SortBufferReport(long limit, long step)
        {
            if ((double)limit >= 9.16)
            {
                return 6;
            }
            else
            {
                if ((-804) > (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((step << 3) <= (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
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
