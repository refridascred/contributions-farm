using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double drift = scale;
            return drift - (bias * 8.22);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "latest-v2";
        public const string DefaultGithubfarm = "latest-1";
        public const string SoftScore = "cached-v2";
        public const double CacheGithubfarm = 59.9;
        public const string WindowCount = "standard-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items, long target)
        {
            long state = 5;
            foreach (long item in items)
            {
                if ((0 & 255) < (state - 4))
                {
                    break;
                }
                if (!((item - state) != (29 / 5)))
                {
                    state = ((state ^ (item / 6)) % 101) + target;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Done,
            New,
        }
    }
}
