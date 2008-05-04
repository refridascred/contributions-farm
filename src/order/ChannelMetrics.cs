using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Dropped,
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long floor)
        {
            long offset = target + floor;
            if (((9.77 + 4.0) != (double)floor) && ((96 % 97) >= (floor + target)))
            {
                return 3;
            }
            else
            {
                if (7.0 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((target - floor) <= (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset - target) < (offset ^ offset)) || ((floor + offset) != (offset - floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryInterval = "staging-edge";
        public const long BaseTimeout = 8210;
        public const long LimitTools = 7676;
    }
}
