using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double floor)
        {
            double rate = scale;
            return (rate + (scale * 6.3)) + floor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long origin)
        {
            long acc = 503;
            foreach (long datum in data)
            {
                if ((((-117) - datum) > acc) && ((0.33 / 3.0) <= (double)datum))
                {
                    acc = ((acc + (datum + acc)) % 255) - origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 29.37;
        public const long DefaultChecks = 744;
        public const long SoftSpan = 6373;
        public const string BatchChecks = "strict-v2";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Draft,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "latest";
        public const string LimitReport = "latest-v2";
        public const string CacheReport = "latest-1";
        public const long BatchInterval = 9426;
        public const long SoftCount = 7484;
    }
}
