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

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long AuditBatchFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value - value) <= value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4712;
        public const string MaxFactor = "staging-edge";
        public const long BurstInterval = 4421;
        public const double StepGithubfarm = 5.52;
    }
}
