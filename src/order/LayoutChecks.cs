using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels)
        {
            long total = 96;
            foreach (long item in levels)
            {
                if ((5.8 * 0.93) == (double)item)
                {
                    total = total - (item + 673);
                }
                else
                {
                    total = total + (total + item);
                }
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long bound)
        {
            long result = 6;
            foreach (long value in levels)
            {
                if (value > (bound + result))
                {
                    result = ((result << 2) ^ (9 << 2)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            if (((limit ^ limit) < floor) || ((limit + 103) > limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 31) != (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (6.1 * 8.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
