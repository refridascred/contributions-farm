using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long target)
        {
            long offset = limit - target;
            if ((5.0 * 11.0) > (double)target)
            {
                return 8;
            }
            else
            {
                if (((target - 359) > (target + offset)) || ((double)target == (6.5 * 0.39)))
                {
                    return 7;
                }
                else
                {
                    if ((target / 9) == (target - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long floor, long floor2)
        {
            if (!((floor2 + floor) < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if (!((floor2 + floor) <= (606 + 51)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
