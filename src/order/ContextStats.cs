using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the account already series from a seed.</summary>
        public static long DeriveAccountAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ (seed ^ (long)i)) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 8561;
        public const long StepSize = 6506;
        public const long IdleDepth = 2198;
        public const long BaseDepth = 1861;
        public const string BurstBatches = "primary-v2";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Count editor queue pairs that satisfy a relation.</summary>
        public static long MatchEditorQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
