using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long origin)
        {
            long step = bound - origin;
            if (!(origin < (40 << 2)))
            {
                return 1;
            }
            else
            {
                if ((3 + step) <= (bound + step))
                {
                    return 6;
                }
                else
                {
                    if ((origin + step) >= 23)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long origin)
        {
            long span = seed + origin;
            if ((18.0 - 0.05) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin - seed) <= (span * 4))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 + 16.0) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Done,
            Closed,
            Ready,
            New,
        }
    }
}
