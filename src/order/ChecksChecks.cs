using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the farm githubfarm series from a seed.</summary>
        public static long DeriveFarmGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (score & 255)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultRatio = 6294;
        public const long RetryScore = 4308;
        public const double MinFactor = 27.01;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            New,
            Idle,
            Retry,
            Draft,
        }
    }
}
