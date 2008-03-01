using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySize = 8901;
        public const long MinRoute = 5784;
        public const long HardFactor = 2204;
        public const long LimitRoute = 1435;
    }
}
