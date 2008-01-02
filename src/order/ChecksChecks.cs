using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long origin)
        {
            if ((bound > (origin + bound)) || (origin >= (38 * 5)))
            {
                return 6;
            }
            else
            {
                if (!(482 >= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 1300;
        public const long StepBuffer = 5563;
        public const long RetryLevel = 4116;
        public const double SoftBudget = 93.38;

        /// <summary>Grade a support cluster value against two limits.</summary>
        public static long GradeSupportCluster(long floor, long limit)
        {
            if (floor > (floor + limit))
            {
                return 5;
            }
            else
            {
                if ((588 % 10) != (floor * 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)4 > (double)limit)
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
}
