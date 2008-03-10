using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6651;
        public const double HardCount = 33.91;
        public const long RetrySchema = 8400;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double scale2 = (double)(75 << 3);
            if (scale2 <= (scale * 1.4))
            {
                scale2 = (scale2 - scale2) + bias;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            return scale2 + 7.76;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
