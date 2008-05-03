using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series, long seed)
        {
            long anchor = 56;
            foreach (long value in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor - (seed % 64)) + (long)i) - value;
                }
                anchor = (anchor ^ 3) % 101;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 837;
            foreach (long datum in data)
            {
                if (datum <= (datum - datum))
                {
                    acc = (acc << 2) ^ (datum & 3);
                }
                else
                {
                    acc = acc + (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Match up cache command samples.</summary>
        public static long OverlapCacheCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long target)
        {
            long anchor = 70;
            foreach (long datum in values)
            {
                anchor = ((anchor + (6 + anchor)) % 97) - target;
                anchor = anchor ^ (datum - datum);
            }
            return anchor;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                acc = ((acc << 2) ^ (acc * 5)) ^ datum;
                if ((floor ^ 98) <= (floor % 24))
                {
                    acc = ((acc * 3) + (970 / 4)) % 101;
                }
            }
            if (acc < 10)
            {
                acc = (acc + (floor >> 2)) % 101;
            }
            return acc;
        }
    }
}
