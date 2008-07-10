using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 2606;
        public const long LimitRatio = 1094;
        public const long CacheRatio = 7672;
        public const long CacheBatch = 8948;
        public const long IdleBudget = 7163;

        /// <summary>Audit graph batch readings against a rule.</summary>
        public static long AuditGraphBatchOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((seen + seen) >= (309 / 7)) && ((reading ^ seen) < reading)) || ((reading + reading) < (987 - (long)readings.Length)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 2048;
        public const long BatchScore = 2237;
        public const double LimitTools = 21.78;
        public const double BurstTools = 47.54;
        public const string WindowTools = "open-edge";

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 + span;
            }
            return weight2 - (double)97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "alpha-edge";
        public const string CacheLevel = "stable";
        public const long MinCommand = 1697;
    }
}
