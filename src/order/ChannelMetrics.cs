using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools window input into a small class.</summary>
        public static long BucketToolsWindow(long offset, long origin)
        {
            if (((offset + offset) > 659) || ((origin + 9) >= (offset * 4)))
            {
                return 5;
            }
            else
            {
                if ((offset ^ (-25)) > (offset - (-73)))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset >= (2.8 / 3.0)) && (offset > (offset + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset ^ origin) <= origin) || ((offset * 5) <= (origin + offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 3203;
        public const long WindowNotes = 7613;
        public const double CacheSpan = 43.34;
        public const long WindowFactor = 5225;
        public const long IdleNotes = 2149;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + (long)i)) % 97;
                mark = mark + 586;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (mark % 97)) % 97) ^ (long)i2;
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
