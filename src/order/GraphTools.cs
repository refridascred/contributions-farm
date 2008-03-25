using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double drift = offset;
            if (drift > ratio)
            {
                drift = drift + drift;
            }
            return drift + offset;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)706 < (double)total)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryCount = 88.12;
        public const string CacheStats = "stable-v2";
        public const long WindowStats = 1702;
        public const string WindowTimeout = "primary-edge";
        public const string BurstStats = "standard-1";
    }
}
