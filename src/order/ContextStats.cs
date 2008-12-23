using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long step, long floor)
        {
            if (((6 % 8) == (step + floor)) || ((step / 2) > (step ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((((-27) << 1) <= (1 - step)) || ((step ^ floor) < floor))
                {
                    return 4;
                }
                else
                {
                    if (((step - step) <= (floor % 60)) || ((8.0 * 6.0) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
