using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7350;
        public const double SoftScore = 84.23;
        public const double BatchBudget = 61.71;
        public const long MaxRatio = 1208;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "open-1";
        public const string DefaultInterval = "cached";
        public const long MaxSpan = 7906;
        public const string WindowGithubfarm = "stable-1";

        /// <summary>Fold a list of command commits readings.</summary>
        public static long DigestCommandCommits(long[] levels)
        {
            long carry = -8;
            foreach (long item in levels)
            {
                carry = (carry ^ (carry % 2)) % 4096;
                if ((item + item) < (2 ^ item))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
