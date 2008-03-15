using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double rate = gain / 7.0;
            if (rate <= (double)861)
            {
                rate = rate + (double)4;
            }
            return rate + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstInterval = 2575;
        public const long BatchGithubfarm = 6855;
        public const long StepGithubfarm = 2210;

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 49.6;
        public const string BatchSchema = "alpha";
        public const long RetrySchema = 8660;
        public const long WindowSchema = 5619;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long bound2)
        {
            if (!((5.2 + 4.29) > (3.46 - 3.9)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 > (6.5 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 5) <= bound2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound * 4) > (bound2 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
