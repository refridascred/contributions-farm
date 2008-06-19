using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            if (762 > seed)
            {
                return 1;
            }
            else
            {
                if (((double)67 >= (6.77 / 6.0)) && ((double)seed <= 19.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "fallback-1";
        public const long BurstBudget = 6972;
        public const long HardDepth = 492;
        public const long HardPayload = 9899;
        public const long IdleWidth = 1874;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
