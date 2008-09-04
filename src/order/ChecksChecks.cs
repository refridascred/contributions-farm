using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (((limit & 3) >= (prev % 16)) || (limit2 < prev))
            {
                return 2;
            }
            else
            {
                if (!((limit2 + limit) > 208))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 1) != (517 + prev))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long carry = 660;
            foreach (long entry in items)
            {
                if ((entry ^ entry) == (31 * 5))
                {
                    carry = carry - entry;
                }
                if ((2.45 + 0.5) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool CheckCommandWindowRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
