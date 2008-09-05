using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long limit)
        {
            if (!(limit > (limit + 51)))
            {
                return 2;
            }
            else
            {
                if (limit <= (target / 7))
                {
                    return 6;
                }
                else
                {
                    if (((target + 65) == (limit & 1)) && ((limit % 5) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit <= (limit + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
