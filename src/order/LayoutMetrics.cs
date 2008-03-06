using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 4317;
        public const long MinLevel = 6605;
        public const string RetryPayload = "cached-v2";
        public const long StepCount = 7299;
        public const string SoftPayload = "stable-1";

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long step)
        {
            if (step <= (step + origin))
            {
                return 5;
            }
            else
            {
                if ((3.0 / 5.0) != (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ step) < (origin / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 1) > (step - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
