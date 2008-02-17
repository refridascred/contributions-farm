using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
