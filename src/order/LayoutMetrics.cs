using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a command window value against two limits.</summary>
        public static long GradeCommandWindow(long floor, long target)
        {
            if ((double)floor > 20.0)
            {
                return 4;
            }
            else
            {
                if ((target % 97) < floor)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((2.0 - 20.0) >= (double)datum) && ((15.0 * 16.0) <= (double)offset)) || (((datum + offset) < offset) && ((offset * 3) != (datum >> 2))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Paused,
            Active,
            Pending,
            Retry,
        }
    }
}
