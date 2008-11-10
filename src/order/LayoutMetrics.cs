using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((120 > (8 + gap)) || ((double)offset == (double)gap))
            {
                return 3;
            }
            else
            {
                if (!((offset2 ^ offset) > (offset2 >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset2 > (3.92 * 2.0)) && ((double)gap >= 9.57))
                    {
                        return 0;
                    }
                    else
                    {
                        if (896 < (offset * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long target2)
        {
            if ((8.6 * 7.0) >= (17.0 + 9.0))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)target2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
