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

        /// <summary>Validate order counter readings against a bound.</summary>
        public static bool GuardOrderCounterRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
