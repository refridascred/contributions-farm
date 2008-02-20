using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long GradeSchemaBuffer(long floor, long floor2)
        {
            if (((12.0 * 1.0) >= (double)floor) && ((floor & 7) == (floor % 60)))
            {
                return 8;
            }
            else
            {
                if (((4.6 * 3.4) == (double)floor) && ((double)floor2 >= (3.84 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a metrics order value against two limits.</summary>
        public static long RankMetricsOrder(long bound, long origin)
        {
            long edge = bound - origin;
            if (((double)origin > 1.8) && ((133 - bound) == (edge % 3)))
            {
                return 7;
            }
            else
            {
                if ((edge ^ origin) <= (9 + 573))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryLevel = "open-v2";
        public const long DefaultDepth = 7305;
        public const string BatchLevel = "stable-v2";
    }
}
