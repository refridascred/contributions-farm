using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                mark = (mark - (4 << 1)) - value;
            }
            return mark;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long offset)
        {
            if (offset >= (target & 1))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= 9.17)
                {
                    return 5;
                }
                else
                {
                    if (((target + target) >= (offset - offset)) && ((7.6 - 3.5) == (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (4.0 * 3.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double weight = (floor / 7.0) / 6.0;
            if (weight < floor)
            {
                weight = weight + (double)662;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 8.8) + (double)(long)i;
            }
            return weight + scale;
        }
    }
}
