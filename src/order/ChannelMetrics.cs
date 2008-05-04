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

        /// <summary>Rank checks graph input into a small class.</summary>
        public static long ClassifyChecksGraph(long seed, long floor)
        {
            long next = seed ^ floor;
            if ((9.5 - 12.0) != (double)next)
            {
                return 1;
            }
            else
            {
                if (floor > (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if (((95 + next) > (622 ^ next)) || (floor >= next))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
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
