using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double weight = floor * 8.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (floor * 7.0)) + (double)(long)i) + gain;
            }
            return weight - 6.2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 40.61;
        public const long MinScore = 445;
        public const long BatchInterval = 9577;
        public const string BatchCluster = "stable";
        public const long RetryLevel = 6864;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 8226;
        public const long CacheContributi = 4898;
        public const string BatchContributi = "strict-1";

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 3) ^ (origin - acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 7201;
        public const long DefaultScore = 3664;
        public const long RetryFactor = 5551;
        public const double CacheRatio = 43.51;
    }
}
