using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (19.0 + 16.0))
            {
                ratio = (ratio + bias2) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias2 / 5.0)) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((double)249 >= (double)matches) && ((matches + step) <= (step << 3))))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxWidth = 721;
        public const long CacheDepth = 8231;
        public const string RetryFactor = "local";
        public const string BurstCount = "legacy-1";
    }
}
