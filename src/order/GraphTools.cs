using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 7281;
        public const long DefaultWindow = 9892;
        public const long RetryScore = 9074;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value - value) > value))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the cache record series from a seed.</summary>
        public static long SeriesCacheRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((origin >> 2) < 2) && ((13.0 / 6.0) == (double)origin))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 101;
                    continue;
                }
                if (((double)acc < (4.63 + 0.5)) || (origin > acc))
                {
                    acc = acc + (acc + acc);
                    acc = (acc - (acc >> 3)) % 255;
                }
                if (!((-58) > (long)i))
                {
                    acc = ((acc * 5) + (acc + origin)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
