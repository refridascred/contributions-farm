using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next profile filter value.</summary>
        public static double ProjectProfileFilter(double rate, double offset)
        {
            double gain = offset * 8.1;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 2.89) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheTimeout = 7248;
        public const string StepLevel = "cached-1";
        public const long BaseContext = 609;
        public const long RetryTimeout = 9985;
        public const long MinCount = 8816;

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long step)
        {
            if (1.03 < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((step ^ step) < (offset / 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)step == (7.1 - 7.7)) && ((offset << 2) < 305))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((13.0 - 9.0) >= (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
