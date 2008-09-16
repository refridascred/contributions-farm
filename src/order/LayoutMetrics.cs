using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long limit)
        {
            if (!(7.9 >= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((limit % 24) <= (limit + bound)) || ((bound ^ 1) > (bound >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit * 3) != (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
