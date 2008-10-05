using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "primary";
        public const long SoftGithubfarm = 7498;
        public const long BaseSpan = 3032;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 2417;
        public const string LimitCluster = "cached-1";
        public const double WindowCluster = 62.36;

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 3;
            foreach (long cell in values)
            {
                if ((614 - cell) > (cell - total))
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total;
        }
    }
}
