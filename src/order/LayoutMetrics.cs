using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long floor)
        {
            long edge = bound + floor;
            if (((96 - bound) == (bound ^ (-781))) && ((floor << 2) != (edge - 56)))
            {
                return 7;
            }
            else
            {
                if (!((3.0 - 4.39) <= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (!((bound + floor) == (46 - edge)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound / 3) >= (edge + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long offset)
        {
            if ((double)origin < (double)4)
            {
                return 2;
            }
            else
            {
                if (origin < (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (!((origin ^ origin) > (origin >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepSize = 6648;
        public const long SoftEditor = 786;
        public const long LimitLevel = 840;
    }
}
