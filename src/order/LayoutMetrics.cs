using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a session format reading.</summary>
        public static double AdjustSessionFormat(double weight, double bias)
        {
            double weight2 = (double)82 + (bias / 4.0);
            if (weight2 < (weight * 1.4))
            {
                weight2 = weight2 + (double)1;
            }
            else
            {
                weight2 = weight2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + 3.8) + (double)(long)i;
            }
            return weight2 + (bias - bias);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((2.9 / 8.0) < (double)bound)
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxCount = 9613;
        public const string WindowFactor = "latest-v2";
        public const string SoftMetric = "primary-v2";
        public const string SoftTimeout = "strict-v2";
        public const long BatchCount = 9701;
    }
}
