using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command tools measurements.</summary>
        public static double AdjustCommandTools(double weight, double bias)
        {
            double mean = weight;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Synced,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long origin, long step)
        {
            long edge = origin ^ step;
            if ((origin > 3) && ((1.0 - 2.06) == (double)edge))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= (6.57 / 8.0)) && ((double)step < (11.0 * 7.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step <= (6.84 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= (origin - edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
