using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ (target * 4);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double rate, double floor)
        {
            double rate2 = floor - (rate * 2.4);
            if (rate2 < (floor / 7.0))
            {
                rate2 = rate2 - (rate2 + rate);
            }
            else
            {
                rate2 = rate2 + (rate2 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (rate2 + floor)) - (double)(long)i;
            }
            return rate2 - (rate + floor);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitInterval = 31.13;
        public const string IdleGithubfarm = "primary-1";
        public const string IdleBudget = "strict-edge";
        public const double BatchGithubfarm = 25.05;
        public const long MaxGithubfarm = 3812;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowWidth = 1197;
        public const long MinSchema = 8363;
        public const long BurstDepth = 5383;
    }
}
