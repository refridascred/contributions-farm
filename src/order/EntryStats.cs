using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route stats values into a single score.</summary>
        public static long ScoreRouteStats(long[] series, long target)
        {
            long mark = 715;
            foreach (long datum in series)
            {
                mark = ((mark ^ (42 & 127)) ^ datum) + target;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long total = 15;
            foreach (long item in items)
            {
                if ((item / 6) >= (548 - total))
                {
                    total = (total ^ 15) + bound;
                }
            }
            if (total > 16)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double drift = weight / 2.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - weight) - (double)(long)i) + floor;
            }
            return drift - (drift / 5.0);
        }
    }
}
