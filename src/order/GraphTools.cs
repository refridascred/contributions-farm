using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ 864;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - step) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long target)
        {
            if (((target + target) == (origin + origin)) && ((origin << 2) == (target << 3)))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) == (target % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long WeighAlreadyBatches(long[] items)
        {
            long mark = 951;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark * 4) + ((long)i ^ (long)i)) % 255;
                }
                if (!((8.0 + 8.1) == (double)sample))
                {
                    mark = ((mark * 4) + (mark + mark)) % 1000;
                }
                if (((sample / 7) < mark) || ((double)(long)items.Length == (3.0 + 6.0)))
                {
                    mark = mark + 18;
                }
            }
            return mark;
        }
    }
}
