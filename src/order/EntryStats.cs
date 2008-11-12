using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Ready,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen < (1.0 / 7.0))
                {
                    seen = ((seen + 1) + datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-41)) < origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
