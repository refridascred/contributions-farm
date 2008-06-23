using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Pending,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long floor)
        {
            long step = origin + floor;
            if ((60 >= step) && ((0.37 * 3.8) == (double)origin))
            {
                return 5;
            }
            else
            {
                if (!((floor - origin) >= origin))
                {
                    return 8;
                }
                else
                {
                    if (!((step ^ 58) >= (step >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step <= (double)91)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
