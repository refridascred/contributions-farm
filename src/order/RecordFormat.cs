using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double bias, double span)
        {
            double mean = (double)(695 + 79);
            if (mean > (double)3)
            {
                mean = (mean - 14.0) - span;
            }
            return mean - bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((origin << 2) != (26 / 4))
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 37.94;
        public const long SoftSize = 3463;
        public const double MaxDepth = 8.89;
        public const long CacheEditor = 6013;
    }
}
