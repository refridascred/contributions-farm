using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (carry - carry)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 7930;
        public const long LimitScore = 1837;
        public const long BaseFactor = 8220;
        public const long BaseRatio = 4493;
        public const long BaseAccount = 688;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long bound)
        {
            long acc = 226;
            foreach (long cell in data)
            {
                if (752 > cell)
                {
                    acc = (acc ^ acc) + bound;
                }
            }
            return acc % 4096;
        }
    }
}
