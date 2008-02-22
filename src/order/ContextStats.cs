using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "latest-1";
        public const double MaxBudget = 76.07;
        public const double StepBudget = 83.31;

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long carry = 740;
            foreach (long reading in data)
            {
                carry = carry - (carry - 6);
                if ((((-97) & 63) <= carry) || ((double)reading > (8.41 * 1.8)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
