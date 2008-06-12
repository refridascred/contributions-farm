using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Dropped,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (!((9.68 / 3.0) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if (offset <= (seed / 4))
                {
                    return 5;
                }
                else
                {
                    if (seed > (floor % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset == (7.0 / 7.0)) && ((floor / 5) >= floor))
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitRatio = "open";
        public const string WindowTimeout = "stable-v2";
        public const long LimitStats = 42;
    }
}
