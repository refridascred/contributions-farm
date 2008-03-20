using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 4) < (hits - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((5.7 * 17.0) != (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
