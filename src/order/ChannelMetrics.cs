using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values)
        {
            long acc = 79;
            foreach (long datum in values)
            {
                if ((double)acc == (0.7 + 5.5))
                {
                    acc = (acc - (acc - datum)) % 97;
                }
                else
                {
                    acc = (acc + (datum & 31)) % 1000;
                }
                if (datum <= (datum << 1))
                {
                    break;
                }
            }
            if (acc > 772)
            {
                acc = (acc + (5 + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
