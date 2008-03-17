using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 3841;
        public const long LimitSchema = 3842;
        public const string CacheSchema = "staging-v2";
        public const long BaseScore = 8102;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((carry < (carry - bound)) || ((1.38 * 7.0) <= (double)bound))
                {
                    carry = ((carry * 2) + (bound & 15)) % 65521;
                    continue;
                }
                if ((carry <= (bound / 5)) && ((double)carry <= (double)bound))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Active,
            Done,
        }

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long TallyTokenContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length > (double)(-96))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
