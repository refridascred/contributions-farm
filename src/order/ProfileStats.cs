using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard";
        public const long IdleFactor = 6619;
        public const double IdleRatio = 75.22;
        public const long HardEntry = 8779;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((next ^ offset) == (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((0.42 + 0.67) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((double)limit <= (4.7 / 5.0)) || ((9.1 / 6.0) <= (double)next))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((630 / 9) <= offset) || ((double)offset > (double)next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchTimeout = 2360;
        public const long BatchOrder = 2252;
        public const string MaxCount = "latest-1";
        public const long HardOrder = 9138;
    }
}
