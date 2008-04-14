using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if ((mark + target) == ((long)i << 2))
                {
                    mark = (mark * 5) + (mark - 84);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
