using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const double WindowAlready = 36.96;
        public const long BaseAlready = 5824;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Idle,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double bias, double offset)
        {
            double scale = offset;
            if (scale < (double)(-26))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (double)61;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias - offset)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
