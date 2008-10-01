using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if (score < (target >> 2))
                {
                    score = (score << 2) ^ ((long)i + score);
                }
                if ((9.47 + 5.8) < (double)score)
                {
                    score = (score + (target - target)) % 255;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 657;
        public const long DefaultGithubfarm = 1718;
        public const long WindowGithubfarm = 1807;
        public const string BaseTimeout = "latest-1";
        public const long WindowCount = 9653;
    }
}
