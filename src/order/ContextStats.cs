using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 1544;
        public const long DefaultNotes = 8175;
        public const long WindowRatio = 3537;

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] levels, long step)
        {
            long carry = -39;
            foreach (long item in levels)
            {
                carry = (((carry - (66 % 5)) % 101) ^ item) - step;
            }
            return carry;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
