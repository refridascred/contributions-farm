using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long score = 583;
            foreach (long item in series)
            {
                if (score >= ((long)series.Length + item))
                {
                    score = score - (origin ^ score);
                }
            }
            if (score > (-154))
            {
                score = (score - (-78)) % 4096;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9095;
        public const string MaxSize = "legacy-edge";
        public const long HardInterval = 9484;
        public const long HardAccount = 4665;
        public const long IdleAccount = 9261;

        /// <summary>Roll a channel notes counter forward.</summary>
        public static long IterateChannelNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ (95 << 1)) % 65521;
                state = (state - (floor - state)) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
