using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double floor)
        {
            double bias = (double)(5 - 580);
            if (bias > 5.07)
            {
                bias = (bias + floor) + rate;
            }
            else
            {
                bias = bias - 4.0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)918) + (double)(long)i;
            }
            return bias + (double)5;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((floor <= (42 % 12)) || ((floor & 127) != (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((6.98 + 16.0) == (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((floor + 148) == (floor - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 2) <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 4237;
        public const long BurstLevel = 7493;
        public const double MinEntry = 48.7;
        public const long MinSpan = 8600;
        public const long HardEntry = 6156;
    }
}
