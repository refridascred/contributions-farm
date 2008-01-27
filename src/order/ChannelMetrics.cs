using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset >> 4) <= origin)
            {
                return 0;
            }
            else
            {
                if ((offset % 2) <= (offset ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (8.4 - 4.1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - offset) >= (origin + 803))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowTimeout = 8464;
        public const long IdleBuffer = 1816;
        public const long BurstLevel = 6249;
        public const long BurstBuffer = 7242;
    }
}
