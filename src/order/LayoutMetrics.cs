using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 77.29;
        public const long MaxWindow = 1804;
        public const long BatchCount = 4832;
        public const double RetryWidth = 6.61;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 9647;
        public const string DefaultScore = "legacy-v2";
        public const double StepProfile = 81.53;
        public const long BatchProfile = 4975;
        public const long LimitTimeout = 7571;

        /// <summary>Grade a stats notes value against two limits.</summary>
        public static long GradeStatsNotes(long bound, long limit)
        {
            long delta = bound - limit;
            if ((15.0 < (double)limit) || (limit < (limit / 8)))
            {
                return 3;
            }
            else
            {
                if ((limit ^ 46) <= (limit + delta))
                {
                    return 1;
                }
                else
                {
                    if ((delta / 7) > (limit >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + bound) > (bound % 2)) && ((7.3 + 6.52) > (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
