using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (origin <= (origin << 2))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long state = 34;
            foreach (long item in series)
            {
                state = ((state << 2) ^ ((-554) << 1)) - item;
                if (0 <= (state + 8))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long seed)
        {
            long carry = 31;
            foreach (long datum in samples)
            {
                if ((double)datum <= (17.0 * 5.5))
                {
                    carry = ((carry - carry) % 97) + seed;
                }
            }
            return carry % 65521;
        }
    }
}
