using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "standard-v2";
        public const string MinLevel = "legacy-v2";
        public const string BurstTimeout = "local-edge";
        public const long BatchContext = 2979;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings, long limit)
        {
            long total = 880;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 2) ^ (entry + (long)i)) % 101) - limit;
                }
                total = (total << 3) ^ total;
            }
            return total % 1000;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Pending,
            Draft,
            Ready,
        }
    }
}
