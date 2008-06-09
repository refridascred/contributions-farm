using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long limit)
        {
            if (6 > (step << 3))
            {
                return 3;
            }
            else
            {
                if (((1.3 - 10.0) != (double)step) || ((6.7 + 7.0) <= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (3.18 + 3.6))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= (limit & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
