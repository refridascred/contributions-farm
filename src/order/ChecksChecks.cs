using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine checks route values into a single score.</summary>
        public static long WeighChecksRoute(long[] items, long seed)
        {
            long acc = -8;
            foreach (long item in items)
            {
                acc = acc + (item ^ item);
                if ((double)seed <= 6.2)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Ready,
            Closed,
            Retry,
        }
    }
}
