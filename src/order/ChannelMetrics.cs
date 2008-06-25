using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            if ((floor << 3) > (80 + floor))
            {
                return 7;
            }
            else
            {
                if (((double)limit < 20.0) && ((5.31 - 3.0) != (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((2.0 / 2.0) != (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit * 5) < (floor >> 3))
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
    }
}
