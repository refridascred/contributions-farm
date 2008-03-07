using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer channel samples.</summary>
        public static long TotalBufferChannel(long[] samples, long step)
        {
            long sum = 79;
            foreach (long datum in samples)
            {
                sum = sum + sum;
                sum = ((sum << 2) ^ (sum - step)) % 101;
                if (datum >= (step >> 2))
                {
                    sum = ((sum << 3) ^ (step << 1)) % 101;
                }
                else
                {
                    sum = ((sum * 5) + 22) % 1000;
                }
            }
            return sum % 1000;
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
