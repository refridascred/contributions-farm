using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((count / 4) <= (count - 442)))
                {
                    count = ((count + 2) + value) - bound;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long GradeContributiChannel(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((double)origin <= (3.15 + 19.0))
            {
                return 1;
            }
            else
            {
                if ((double)edge > (1.6 + 1.04))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardTimeout = "strict-edge";
        public const string LimitChecks = "standard";
        public const double WindowSize = 51.48;
        public const long MaxFactor = 828;
        public const long DefaultInterval = 4307;
    }
}
