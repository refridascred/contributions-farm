using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultSize = "legacy-1";
        public const string DefaultChannel = "primary";
        public const long BaseChannel = 5892;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long step)
        {
            if (11.0 <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((limit / 9) < (49 * 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
