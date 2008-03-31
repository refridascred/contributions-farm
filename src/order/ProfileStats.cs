using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of profile payload readings.</summary>
        public static long MatchProfilePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            if ((double)offset != (7.0 * 20.0))
            {
                return 1;
            }
            else
            {
                if (85 >= (offset >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((double)step > (8.9 / 8.0)) && ((offset ^ step) <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.0 - 18.0) <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
