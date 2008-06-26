using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(datum > (count - datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 3222;
        public const long MaxTools = 3043;
        public const long LimitWidth = 7214;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "alpha";
        public const long WindowDepth = 3994;
        public const string HardInterval = "standard-v2";
        public const string DefaultWidth = "primary-edge";
        public const long IdleContributi = 2742;
    }
}
