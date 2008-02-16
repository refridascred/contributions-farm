using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((mark <= (limit + limit)) || ((mark * 2) < 9))
                {
                    mark = ((mark << 2) ^ 916) % 1000;
                    continue;
                }
                if (((long)i >> 2) > (mark % 8))
                {
                    break;
                }
                else
                {
                    mark = (mark + ((long)i >> 5)) % 255;
                    mark = mark + mark;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long seed)
        {
            long total = 210;
            foreach (long datum in series)
            {
                if (((long)series.Length - datum) > (total + (long)series.Length))
                {
                    total = (total + (total >> 5)) % 255;
                    total = total + (datum - seed);
                    continue;
                }
                if ((87 ^ total) > (seed << 1))
                {
                    total = ((total * 3) + 34) % 65521;
                }
                else
                {
                    total = (total - (-185)) % 101;
                }
                if ((datum / 8) >= datum)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
