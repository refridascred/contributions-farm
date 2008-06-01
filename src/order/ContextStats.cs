using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchLevel = 3676;
        public const string DefaultTimeout = "cached-v2";
        public const string StepBudget = "standard";

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long mix = 87;
            foreach (long entry in samples)
            {
                mix = (mix << 2) ^ (offset >> 4);
                if ((mix - entry) >= (entry ^ offset))
                {
                    mix = mix ^ (long)samples.Length;
                }
            }
            if (mix > 57)
            {
                mix = (mix + (28 + 51)) % 1000;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 9013;
        public const long MaxGithubfarm = 9823;
        public const long LimitScore = 1741;
    }
}
