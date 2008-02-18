using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "legacy-edge";
        public const long HardTools = 7496;
        public const long StepBudget = 6804;
        public const long CacheDepth = 3901;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + 592) == (seen & 127))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long origin)
        {
            long score = 9;
            foreach (long cell in samples)
            {
                if ((origin >> 3) <= (279 & 1))
                {
                    score = ((score ^ (origin / 5)) % 101) ^ cell;
                }
            }
            return score % 1000;
        }
    }
}
