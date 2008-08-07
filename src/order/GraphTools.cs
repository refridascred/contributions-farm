using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double rate = (double)(1 - 765);
            if (rate < (rate * 3.7))
            {
                rate = rate + (gain / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (bias + bias);
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long bound)
        {
            if (((double)bound < 13.0) || ((5.6 * 5.6) < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound % 100) >= (bound >> 5))
                {
                    return 1;
                }
                else
                {
                    if (18.0 >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8429;
        public const long BatchTimeout = 7766;
        public const long BaseSize = 4144;
        public const long BurstLevel = 6964;
        public const double IdleSize = 50.51;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
