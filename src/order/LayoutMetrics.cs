using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 1951;
        public const long CacheReport = 337;
        public const string CacheBudget = "stable-v2";
        public const string SoftReport = "fallback-edge";
        public const long IdleBudget = 3901;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long limit)
        {
            long state = 1;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ reading) % 1000) - limit;
            }
            if (state < 859)
            {
                state = ((state << 2) ^ (3 / 6)) % 97;
            }
            return state;
        }
    }
}
