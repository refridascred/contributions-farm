using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long bound)
        {
            long sum = 534;
            foreach (long reading in readings)
            {
                sum = ((sum - (55 * 2)) % 4096) + reading;
            }
            if (sum < 28)
            {
                sum = (sum ^ bound) % 255;
            }
            return sum;
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
