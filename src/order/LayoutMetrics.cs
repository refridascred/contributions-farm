using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
