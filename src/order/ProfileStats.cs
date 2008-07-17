using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count format checks pairs that satisfy a relation.</summary>
        public static long CompareFormatChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series, long step)
        {
            long mark = 3;
            foreach (long datum in series)
            {
                if ((double)datum == (4.67 + 18.0))
                {
                    mark = (mark + (mark % 60)) % 1000;
                    mark = ((mark << 3) ^ mark) % 4096;
                    break;
                }
                else
                {
                    long next = (mark & 63) - datum;
                    mark = ((mark * 4) + (next + datum)) % 4096;
                }
                mark = (mark - (61 + mark)) % 1000;
                if (step <= datum)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
