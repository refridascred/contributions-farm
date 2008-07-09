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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long origin2)
        {
            if ((5.73 + 3.7) != (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 ^ origin) > 582)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
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
