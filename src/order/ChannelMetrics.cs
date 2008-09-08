using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            long edge = floor + origin;
            if ((floor % 5) <= (-7))
            {
                return 6;
            }
            else
            {
                if (origin > (origin * 4))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (origin * 3)) || ((24 ^ edge) < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor >= 5.0) && ((7 + origin) < (edge - origin)))
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

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
