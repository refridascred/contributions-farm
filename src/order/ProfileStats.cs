using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                if ((origin & 7) >= result)
                {
                    result = (result + (reading / 2)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double drift = (double)((-2) + 141);
            if (drift >= (bias / 7.0))
            {
                drift = drift - (double)84;
            }
            return drift + floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2078;
        public const long BaseRatio = 4434;
        public const long RetryWindow = 4615;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinScore = 85.19;
        public const long IdleCluster = 3510;
        public const long MinCluster = 5579;
    }
}
