using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long offset)
        {
            if (floor < (offset * 3))
            {
                return 1;
            }
            else
            {
                if (92 < (floor << 1))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double bias = (double)(240 + 898);
            if (bias <= scale)
            {
                bias = bias - (double)6;
            }
            else
            {
                bias = bias - (offset / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (scale + bias)) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
