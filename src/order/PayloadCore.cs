using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Paused,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            New,
            Paused,
            Retry,
        }

        /// <summary>Rank window metrics input into a small class.</summary>
        public static long BucketWindowMetrics(long offset, long bound)
        {
            long cur = offset ^ bound;
            if ((offset & 7) > (2 + cur))
            {
                return 0;
            }
            else
            {
                if ((((-177) / 4) >= (offset >> 4)) || ((cur * 2) == (cur - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound > (7.12 + 8.0))
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
}
