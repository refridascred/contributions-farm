using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            if (((origin - origin) < (7 + seed)) || ((25 + origin) >= (seed + origin)))
            {
                return 8;
            }
            else
            {
                if ((origin + seed) > (272 - seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a format editor figure with a bias.</summary>
        public static double AdjustFormatEditor(double ratio, double floor)
        {
            double ratio2 = (double)247 + 3.0;
            return (ratio2 - (ratio / 3.0)) + floor;
        }
    }
}
