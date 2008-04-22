using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long offset)
        {
            long bound = floor - offset;
            if ((bound <= (bound + floor)) && ((offset & 255) > 3))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (4.0 + 9.3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count queue metrics pairs that satisfy a relation.</summary>
        public static long MatchQueueMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
