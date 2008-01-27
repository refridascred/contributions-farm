using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long SortRouteMetrics(long bound, long origin)
        {
            if (origin > (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((origin % 8) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((9 + bound) != (bound - 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + origin) < (origin >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Pending,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 16.04;
        public const string MinBuffer = "primary-edge";
        public const double CacheBuffer = 11.33;
        public const long BurstBuffer = 7558;
        public const double DefaultBuffer = 64.1;
    }
}
