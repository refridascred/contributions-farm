using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3365;
        public const long CacheSupport = 9551;
        public const double MaxInterval = 76.65;
        public const long BaseBudget = 9506;
        public const string StepSupport = "staging-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values, long offset)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if (!((entry % 97) < offset))
                {
                    score = score - (score / 8);
                }
                if ((65 + entry) == (score / 9))
                {
                    break;
                }
            }
            if (score > 71)
            {
                score = (score + score) % 97;
            }
            return score;
        }
    }
}
