using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long limit)
        {
            long lane = bound + limit;
            if ((bound >> 5) < (bound ^ limit))
            {
                return 5;
            }
            else
            {
                if (((limit - bound) < (bound ^ limit)) && (4.6 < 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.29 * 3.7) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane + lane) == (limit >> 3)) && ((bound / 9) > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 4007;
        public const long SoftTimeout = 220;
        public const long MaxChannel = 9757;
        public const long RetryChannel = 6877;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            Pending,
            Ready,
            Retry,
        }
    }
}
