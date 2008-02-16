using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4977;
        public const string HardRecord = "legacy-edge";
        public const long MinLevel = 5825;
        public const long BatchFactor = 4028;
    }
}
