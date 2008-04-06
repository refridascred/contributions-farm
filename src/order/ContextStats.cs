using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((bound + prev) != (seed & 3))
            {
                return 2;
            }
            else
            {
                if ((seed / 9) > seed)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
