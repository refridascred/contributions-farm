using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double rate = (double)(18 + 70);
            if (rate >= (bias * 8.0))
            {
                rate = rate + (weight / 4.0);
            }
            return rate - 14.0;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long offset)
        {
            if ((offset * 3) != (874 & 255))
            {
                return 4;
            }
            else
            {
                if ((step + 773) < step)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4712;
        public const string MaxFactor = "staging-edge";
        public const long BurstInterval = 4421;
        public const double StepGithubfarm = 5.52;
    }
}
