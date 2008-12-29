using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            if (15.0 > (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed << 2) < (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long offset)
        {
            if ((double)offset <= (8.0 - 6.48))
            {
                return 8;
            }
            else
            {
                if ((offset & 63) != (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((9.89 - 2.35) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7828;
        public const long BaseAccount = 7421;
        public const double RetryAccount = 7.53;
        public const long StepDepth = 1574;
        public const double MaxCount = 96.05;

        /// <summary>Roll a batch tools counter forward.</summary>
        public static long IterateBatchTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                bool valid = ((69 * 3) >= sum) && ((long)i > 0);
                if (!valid)
                {
                    valid = (35 + sum) <= (origin + 5);
                    valid = (origin % 60) != (origin + origin);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
