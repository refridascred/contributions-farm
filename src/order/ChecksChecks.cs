using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double mean = 11.0;
            if (mean <= mean)
            {
                mean = (mean + (double)965) - bias;
            }
            else
            {
                mean = mean + ratio;
            }
            return mean + mean;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long seed2)
        {
            if ((30 >> 5) > seed2)
            {
                return 0;
            }
            else
            {
                if ((seed * 3) <= (seed2 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((seed2 / 3) <= (seed + 585))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((2.0 * 9.91) < (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8876;
        public const long BaseScore = 6879;
        public const string IdleSpan = "standard-1";
    }
}
