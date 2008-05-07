using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool CheckCounterEditorRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long step2)
        {
            long slot = step + step2;
            if (((step + step) >= (slot * 5)) && (step2 >= (545 - step2)))
            {
                return 4;
            }
            else
            {
                if ((step + step) == (slot + step2))
                {
                    return 0;
                }
                else
                {
                    if (!((step2 + step) > 12))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < 1.0) && ((230 ^ 42) <= (step2 & 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally * 3) < (cell - 84))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
