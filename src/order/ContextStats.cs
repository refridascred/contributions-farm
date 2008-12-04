using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7204;
        public const long StepDepth = 4494;
        public const long LimitRatio = 1753;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long score = 941;
            foreach (long value in items)
            {
                score = (((score << 2) ^ (8 * 4)) ^ value) + origin;
            }
            return score % 1000;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Done,
            Locked,
            Stale,
        }
    }
}
