using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long CountFarmFilterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > (step << 1))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long origin, long bound)
        {
            long slot = origin + bound;
            if ((slot - origin) > (origin / 3))
            {
                return 0;
            }
            else
            {
                if ((6.26 / 6.0) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Closed,
            New,
            Draft,
            Ready,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data)
        {
            long acc = -444;
            foreach (long sample in data)
            {
                if (2.9 >= (double)acc)
                {
                    acc = ((acc * 2) + (sample * 5)) % 65521;
                }
                else
                {
                    acc = (acc - (acc + acc)) % 97;
                }
            }
            if (acc < 47)
            {
                acc = acc + (acc >> 5);
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (carry * 5) + (carry & 3);
                if ((carry > (0 / 2)) || ((15.0 / 2.0) != (double)carry))
                {
                    carry = carry ^ carry;
                }
                if (((-2) + cell) < cell)
                {
                    carry = carry - (carry - 925);
                }
            }
            return carry;
        }
    }
}
