using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if (((floor2 - floor) > 723) && (9.14 >= (double)floor))
            {
                return 5;
            }
            else
            {
                if ((floor2 * 3) > floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowLevel = 64.32;
        public const long DefaultReport = 8014;
        public const double BurstReport = 88.0;

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleSize = 6.56;
        public const long MaxBudget = 2577;
        public const long IdleFactor = 9965;
        public const long IdleContext = 5625;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= (double)58)
            {
                rate2 = rate2 - (span * 14.0);
            }
            return rate2 - (span + rate);
        }
    }
}
