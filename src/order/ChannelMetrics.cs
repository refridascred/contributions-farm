using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long IterateQueueReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total << 2) ^ (limit & 15)) % 97) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long step)
        {
            long mark = -2;
            foreach (long sample in items)
            {
                if (mark >= (step ^ sample))
                {
                    mark = (mark - (mark - (-590))) % 1000;
                }
                if ((sample / 5) >= ((-793) + mark))
                {
                    break;
                }
            }
            if (mark < (-493))
            {
                mark = (mark ^ 88) % 255;
            }
            return mark % 1000;
        }
    }
}
