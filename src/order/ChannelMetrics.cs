using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((seed2 + 812) < (prev << 2))
            {
                return 7;
            }
            else
            {
                if ((seed2 * 3) == ((-492) + seed2))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) == (prev * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Ready,
            Active,
            Synced,
            Queued,
        }
    }
}
