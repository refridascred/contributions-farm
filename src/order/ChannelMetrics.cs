using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            if (target >= (target - origin))
            {
                return 5;
            }
            else
            {
                if ((target >> 2) <= target)
                {
                    return 2;
                }
                else
                {
                    if (1.0 > (double)origin)
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

        /// <summary>Grade a context session value against two limits.</summary>
        public static long ClassifyContextSession(long seed, long floor)
        {
            long gap = seed - floor;
            if ((seed >> 1) != (seed * 5))
            {
                return 0;
            }
            else
            {
                if ((double)gap > (4.0 - 5.76))
                {
                    return 7;
                }
                else
                {
                    if (!((floor / 7) != (floor << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor >= 8.3)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
