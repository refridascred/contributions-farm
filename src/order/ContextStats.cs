using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double drift = (double)6 + (bias + 6.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (scale + bias)) - (double)(long)i;
            }
            return drift - (double)(-257);
        }
    }
}
