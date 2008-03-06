using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long target)
        {
            long next = step ^ target;
            if ((6.6 - 12.0) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target - 455) >= (next + step))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long SortReportCounter(long bound, long origin)
        {
            long span = bound + origin;
            if ((48 + span) <= bound)
            {
                return 0;
            }
            else
            {
                if ((7.07 * 1.3) >= (double)span)
                {
                    return 3;
                }
                else
                {
                    if (((29 * 5) < (origin >> 4)) || ((bound - 0) < (92 - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >= (origin + origin)) || (origin <= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
