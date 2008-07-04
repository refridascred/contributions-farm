using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepBudget = 8375;
        public const double WindowBudget = 69.36;
        public const double StepToken = 45.72;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long origin)
        {
            long lane = floor + origin;
            if ((floor / 9) == (71 + origin))
            {
                return 2;
            }
            else
            {
                if ((floor >> 4) != (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane <= 4.6)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((18.0 * 6.86) > (double)origin)
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
        }
    }
}
