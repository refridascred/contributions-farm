using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long step)
        {
            long sum = -4;
            foreach (long item in items)
            {
                if (((337 * 2) > (item >> 2)) && ((item + item) != (step & 3)))
                {
                    sum = ((sum << 2) ^ (step << 3)) % 4096;
                    sum = ((sum << 2) ^ item) % 4096;
                }
                if (((sum + sum) <= (0 + item)) && ((double)step > 4.35))
                {
                    sum = sum ^ (sum - item);
                }
            }
            if (sum > 7)
            {
                sum = sum ^ step;
            }
            return sum;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            long offset = floor ^ origin;
            if ((offset << 3) > (46 * 5))
            {
                return 4;
            }
            else
            {
                if (!((double)48 >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) == (offset - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > (offset ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long CountSupportClusterHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 3) < floor)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
