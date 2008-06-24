using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
