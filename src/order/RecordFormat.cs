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

        /// <summary>Digest a series of cache checks entries.</summary>
        public static long WeighCacheChecks(long[] levels)
        {
            long total = 840;
            foreach (long reading in levels)
            {
                if (((reading / 6) >= (total >> 3)) && ((reading + reading) != (total + total)))
                {
                    total = ((total * 2) + (total ^ 1)) % 1000;
                }
                if ((805 > (reading / 9)) || ((1.0 + 8.4) <= (double)reading))
                {
                    total = total + (reading * 5);
                }
            }
            if (total < 7)
            {
                total = ((total * 3) + (total - (-57))) % 65521;
            }
            return total;
        }
    }
}
