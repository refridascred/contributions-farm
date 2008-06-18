using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream route pairs that satisfy a relation.</summary>
        public static long MatchStreamRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            if ((double)bound < (9.02 + 1.9))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
