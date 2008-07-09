using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 31.47;
        public const double BaseGithubfarm = 67.18;
        public const double MinCount = 78.55;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 93.87;
        public const long HardWidth = 9354;
        public const string RetryFactor = "alpha-edge";
        public const long DefaultFactor = 8998;
    }
}
