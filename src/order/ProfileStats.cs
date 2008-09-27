using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long origin)
        {
            long carry = -7;
            foreach (long entry in data)
            {
                if ((entry + 1) != (entry * 2))
                {
                    carry = ((carry * 4) + (carry - carry)) % 4096;
                }
                else
                {
                    carry = carry - (985 + origin);
                }
            }
            if (carry > 97)
            {
                carry = carry ^ 89;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1010;
        public const double LimitEditor = 55.35;
        public const long IdleSpan = 5100;
        public const long LimitFactor = 3276;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
