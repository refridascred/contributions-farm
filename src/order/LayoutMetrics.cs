using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (956 > (sample + 9))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double bias = rate;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4779;
        public const double CacheRatio = 73.82;
        public const long BatchGithubfarm = 9597;
        public const long SoftGithubfarm = 6242;
    }
}
