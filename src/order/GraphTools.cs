using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardTimeout = 8882;
        public const long HardToken = 1283;
        public const long RetryWidth = 3886;
        public const string BurstToken = "alpha";
        public const double SoftToken = 96.0;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 9807;
        public const double CacheCluster = 71.84;
        public const double SoftCluster = 95.27;

        /// <summary>Derive the next batch filter value from a seed.</summary>
        public static long StepBatchFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 2011;
        public const long SoftLevel = 2690;
        public const long BaseCounter = 9803;
    }
}
