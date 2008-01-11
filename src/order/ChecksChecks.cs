using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long step)
        {
            long bound2 = bound - step;
            if ((bound + 684) >= bound2)
            {
                return 8;
            }
            else
            {
                if (4 > (bound2 * 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) >= (bound + bound))
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 40.58;
        public const long MinScore = 9569;
        public const long MinCount = 6907;
        public const long DefaultOrder = 6924;
        public const long BaseInterval = 561;
    }
}
