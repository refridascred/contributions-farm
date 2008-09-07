using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Classify a support buffer pair into a bucket.</summary>
        public static long ClassifySupportBuffer(long limit, long step)
        {
            long span = limit - step;
            if (((limit * 3) <= (limit << 1)) && (span < (span + (-486))))
            {
                return 5;
            }
            else
            {
                if ((1.77 * 7.91) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((8.26 + 7.0) == (double)step) || ((span ^ limit) <= (step + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit < (limit << 3)) || ((limit << 3) > step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
