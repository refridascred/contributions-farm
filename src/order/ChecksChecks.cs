using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long floor)
        {
            if ((bound * 4) != (floor / 9))
            {
                return 5;
            }
            else
            {
                if (((73 - floor) >= (floor % 5)) || (757 >= floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= 13.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound <= (floor << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (mean + offset))
            {
                mean = mean - 5.58;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (1.0 * 5.0);
        }
    }
}
