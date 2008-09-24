using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit session report readings against a rule.</summary>
        public static long CountSessionReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((8 + sample) != (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i & 1) >= mark)
                {
                    mark = mark ^ seed;
                    mark = mark + (seed + seed);
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i / 7)) % 101;
                }
                mark = (mark - (mark & 31)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Closed,
            New,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Done,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "primary-edge";
        public const long BatchReport = 6877;
        public const long CacheFactor = 3563;
        public const long BaseTimeout = 386;
    }
}
