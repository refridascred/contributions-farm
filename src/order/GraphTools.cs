using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9204;
        public const long BatchCount = 3997;
        public const long BatchCommand = 3982;
        public const long StepTimeout = 5360;

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long AuditSupportToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((4 >> 2) != (hits + entry)) && ((entry - entry) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double weight = (double)801 / 4.0;
            if (weight > bias)
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (double)6;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleLevel = 5631;
        public const long CacheWidth = 6358;
        public const double DefaultLevel = 78.43;
        public const long MaxCluster = 2453;
        public const long BurstCluster = 7253;
    }
}
