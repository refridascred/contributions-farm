using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Failed,
            New,
            Closed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long carry = 462;
            foreach (long entry in levels)
            {
                carry = ((carry + (carry - bound)) % 4096) + entry;
            }
            if (carry < 12)
            {
                carry = (carry + bound) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long origin)
        {
            if (!((origin - limit) > (origin + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit & 31) < 642)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7828;
        public const long BaseAccount = 7421;
        public const double RetryAccount = 7.53;
        public const long StepDepth = 1574;
        public const double MaxCount = 96.05;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (result + (long)i)) % 101;
                result = result - (result / 6);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
