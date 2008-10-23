using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstRatio = "stable-v2";
        public const double IdleSize = 74.92;
        public const string WindowSize = "latest";
        public const long MinCluster = 8573;
        public const long MaxCount = 8819;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 920;
        public const long WindowLevel = 5080;
        public const double LimitFarm = 52.03;
        public const long HardFarm = 9145;
        public const double IdleDepth = 24.19;
    }
}
