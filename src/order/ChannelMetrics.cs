using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double weight, double floor)
        {
            double weight2 = 19.0;
            if (weight2 <= (6.0 - weight))
            {
                weight2 = (weight2 - weight2) - floor;
            }
            return weight2 - (double)13;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "legacy-1";
        public const long SoftOrder = 3284;
        public const long SoftLevel = 1098;
        public const double StepBudget = 42.42;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
