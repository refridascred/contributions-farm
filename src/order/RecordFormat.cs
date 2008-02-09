using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((-69) << 3) > hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinBudget = "cached-v2";
        public const double LimitLevel = 63.82;
        public const double BaseBudget = 53.23;
        public const long LimitSpan = 4593;
        public const long CacheGraph = 2602;

        /// <summary>Match up buffer batch samples.</summary>
        public static long MatchBufferBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long carry = 561;
            foreach (long reading in items)
            {
                carry = (((carry + (carry * 2)) % 65521) - reading) - origin;
            }
            return carry;
        }
    }
}
