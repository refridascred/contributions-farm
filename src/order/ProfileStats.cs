using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheDepth = "stable-edge";
        public const string IdleCommand = "stable-edge";
        public const long MaxCommand = 8998;
        public const long RetryBudget = 7437;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data)
        {
            long carry = -35;
            foreach (long entry in data)
            {
                carry = carry + (carry + entry);
            }
            if (carry < 189)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of filter stats readings.</summary>
        public static long ScoreFilterStats(long[] samples)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                acc = (((acc * 5) + (31 - acc)) % 1000) - entry;
                acc = acc ^ (acc * 4);
                acc = acc - 2;
            }
            return acc;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
