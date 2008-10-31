using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long step)
        {
            if ((target / 4) != (step - target))
            {
                return 2;
            }
            else
            {
                if ((6.86 + 0.4) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (step << 2))
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

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Retry,
            Ready,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
