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

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 920;
        public const long WindowLevel = 5080;
        public const double LimitFarm = 52.03;
        public const long HardFarm = 9145;
        public const double IdleDepth = 24.19;
    }
}
