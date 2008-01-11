using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 40.58;
        public const long MinScore = 9569;
        public const long MinCount = 6907;
        public const long DefaultOrder = 6924;
        public const long BaseInterval = 561;
    }
}
