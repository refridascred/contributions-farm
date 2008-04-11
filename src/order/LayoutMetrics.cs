using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
