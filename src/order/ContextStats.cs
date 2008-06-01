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

        /// <summary>Classify a githubfarm batches pair into a bucket.</summary>
        public static long RankGithubfarmBatches(long step, long floor)
        {
            long cur = step + floor;
            if ((floor + step) == (floor + 937))
            {
                return 5;
            }
            else
            {
                if ((cur + 62) <= (floor + cur))
                {
                    return 7;
                }
                else
                {
                    if ((floor + (-8)) == (cur % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
