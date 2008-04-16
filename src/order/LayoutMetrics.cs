using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = (result - ((long)i + result)) % 97;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
