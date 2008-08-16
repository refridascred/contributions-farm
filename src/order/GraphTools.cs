using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "latest-edge";
        public const double BatchFactor = 69.86;
        public const string IdleSchema = "strict-v2";
        public const string CacheSpan = "latest-v2";
        public const long DefaultSchema = 4379;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values)
        {
            long result = 461;
            foreach (long cell in values)
            {
                if (!!(result <= (cell ^ cell)))
                {
                    result = result - (cell % 5);
                }
                if ((result < cell) && ((cell + 95) <= (90 / 5)))
                {
                    result = (result ^ (cell - cell)) % 101;
                }
            }
            return result;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data)
        {
            long carry = 95;
            foreach (long item in data)
            {
                carry = (carry + 301) % 97;
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry - (item * 4)) % 65521) + (long)i;
                }
                if ((item + item) != (item >> 1))
                {
                    carry = carry - (carry * 2);
                }
                else
                {
                    carry = carry + (carry + 0);
                }
            }
            return carry;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((0 & 63) >= (seen << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
