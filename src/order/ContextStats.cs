using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long floor, long step)
        {
            if (((floor ^ 944) > (step ^ step)) && ((floor % 100) == (step % 64)))
            {
                return 3;
            }
            else
            {
                if (((9.4 / 4.0) != (double)floor) && ((2.76 - 2.16) >= (double)floor))
                {
                    return 0;
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

        /// <summary>Validate support notes readings against a bound.</summary>
        public static bool CheckSupportNotesLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
