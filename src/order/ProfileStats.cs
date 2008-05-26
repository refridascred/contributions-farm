using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of stream payload readings.</summary>
        public static long OverlapStreamPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 34.28;
        public const string CacheWidth = "alpha-1";
        public const string IdleRatio = "local-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 9243;
        public const string MinFormat = "open";
        public const long BurstFormat = 6010;
        public const long CacheDepth = 6338;
        public const long BatchFormat = 5663;

        /// <summary>Blend two filter buffer measurements.</summary>
        public static double AdjustFilterBuffer(double gain, double bias)
        {
            double rate = 12.0;
            if (rate <= gain)
            {
                rate = rate - (rate / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (rate + bias);
        }
    }
}
