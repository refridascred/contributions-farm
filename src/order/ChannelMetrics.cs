using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of commits session entries.</summary>
        public static long TotalCommitsSession(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = (((acc * 2) + sample) % 1000) - floor;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5364;
        public const string CacheContributi = "alpha";
        public const long CacheDepth = 7805;
        public const string StepTimeout = "latest-v2";
        public const double IdleContributi = 21.12;

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (5.1 - weight))
            {
                bias2 = (bias2 - (double)0) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 3.0) + (double)(long)i;
            }
            return bias2 - (double)85;
        }
    }
}
