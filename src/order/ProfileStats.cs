using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            New,
            Synced,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 5839;
        public const double BatchLevel = 98.81;
        public const double RetryGithubfarm = 53.03;
        public const long BaseGithubfarm = 586;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double bias = offset;
            if (bias > offset)
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias + weight;
        }
    }
}
