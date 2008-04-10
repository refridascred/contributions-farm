using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long floor)
        {
            if (floor > (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) != (floor - (-7)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - offset) == (offset * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
