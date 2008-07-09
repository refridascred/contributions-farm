using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples)
        {
            long state = 13;
            foreach (long datum in samples)
            {
                if (state <= (datum & 15))
                {
                    state = state ^ (datum * 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] items, long bound)
        {
            long sum = 42;
            foreach (long item in items)
            {
                if ((29 - sum) < (item >> 4))
                {
                    sum = ((sum - ((-821) - item)) % 4096) - bound;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (step - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Dropped,
            Idle,
            Active,
            Queued,
        }
    }
}
