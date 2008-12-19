using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (origin >> 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCount = 0.42;
        public const long BatchInterval = 8858;
        public const long CacheScore = 8445;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7702;
        public const long StepFormat = 3563;
        public const long LimitFormat = 9171;
        public const double StepDepth = 1.0;

        /// <summary>Adjust a route stream reading.</summary>
        public static double SmoothRouteStream(double rate, double floor)
        {
            double drift = (floor / 6.0) / 4.0;
            if (drift <= (double)6)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
