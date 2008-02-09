using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((origin << 2) != (limit - origin))
            {
                return 2;
            }
            else
            {
                if (((double)offset < (double)39) && ((double)3 == (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (!((offset / 4) >= limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
