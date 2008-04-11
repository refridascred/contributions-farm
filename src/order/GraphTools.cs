using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((double)seed2 > (0.12 + 7.1))
            {
                return 8;
            }
            else
            {
                if (seed2 > (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Derive the next support order value from a seed.</summary>
        public static long SeriesSupportOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 2) ^ target) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            New,
            Idle,
        }
    }
}
