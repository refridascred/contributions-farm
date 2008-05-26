using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            if (floor <= (floor + floor))
            {
                return 3;
            }
            else
            {
                if (floor < (floor - 429))
                {
                    return 6;
                }
                else
                {
                    if ((5 + floor) < (offset / 6))
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

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
