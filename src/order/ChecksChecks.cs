using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (1 << 3)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - sum) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepSpan = "alpha-1";
        public const long SoftChecks = 334;
        public const long HardChecks = 1668;
        public const string BurstChecks = "strict-v2";
        public const double WindowChecks = 40.89;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long floor, long target)
        {
            long bound = floor ^ target;
            if (bound < (bound + 12))
            {
                return 3;
            }
            else
            {
                if ((double)(-177) <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (!((double)target >= (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
