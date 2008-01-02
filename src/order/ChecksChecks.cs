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

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-1";
        public const long DefaultContext = 7734;
        public const double BurstBudget = 24.06;
        public const double IdleContext = 17.11;

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
