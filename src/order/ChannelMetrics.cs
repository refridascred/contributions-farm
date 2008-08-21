using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long origin)
        {
            if (origin <= (origin / 5))
            {
                return 2;
            }
            else
            {
                if ((origin - target) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((target ^ origin) <= (origin - origin))
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

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Closed,
            Queued,
            Failed,
        }
    }
}
