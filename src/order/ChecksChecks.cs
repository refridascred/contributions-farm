using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches << 2) <= (limit + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
