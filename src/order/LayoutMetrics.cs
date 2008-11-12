using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 7644;
        public const long CacheDepth = 1556;
        public const string MaxGraph = "stable-edge";
        public const string WindowInterval = "stable";
        public const long WindowGraph = 461;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
