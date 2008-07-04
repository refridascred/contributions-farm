using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultScore = 9522;
        public const long MinOrder = 1763;
        public const long LimitSize = 1568;
        public const long MinTimeout = 3773;
        public const long BatchFactor = 5062;

        /// <summary>Rank graph entry input into a small class.</summary>
        public static long GradeGraphEntry(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((diff + diff) >= (-4))
            {
                return 0;
            }
            else
            {
                if (14.0 <= (double)diff)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultFactor = 6.05;
        public const double BurstRoute = 74.52;
        public const string BatchRoute = "fallback-edge";
    }
}
