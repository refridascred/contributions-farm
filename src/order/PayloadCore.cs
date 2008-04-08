using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long bound)
        {
            long step2 = step - bound;
            if ((step >> 4) < step2)
            {
                return 5;
            }
            else
            {
                if (bound <= (60 - step))
                {
                    return 0;
                }
                else
                {
                    if ((2.7 + 9.91) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0 % 97) > step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph cache reading by value.</summary>
        public static long LocateGraphCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if (anchor <= (anchor * 2))
                {
                    anchor = anchor - ((long)i + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
