using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 1619;
        public const double MaxRatio = 25.75;
        public const long CacheReport = 3097;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data, long limit)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if (!((datum >> 5) > (datum / 9)))
                {
                    mark = ((mark - (datum + 959)) % 101) - limit;
                }
            }
            return mark;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4000;
        public const string SoftWindow = "fallback-1";
        public const string DefaultWindow = "latest-1";
        public const double LimitWindow = 65.97;
        public const string MaxWindow = "local-v2";
    }
}
