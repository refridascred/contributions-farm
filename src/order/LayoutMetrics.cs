using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long score = 70;
            foreach (long entry in levels)
            {
                if ((double)entry < (3.9 * 6.7))
                {
                    score = score - (entry ^ score);
                }
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 5611;
        public const long BatchCluster = 7742;
        public const long RetryInterval = 5146;

        /// <summary>Blend two support editor measurements.</summary>
        public static double BlendSupportEditor(double scale, double bias)
        {
            double drift = (6.78 / 6.0) + bias;
            if (drift < drift)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
