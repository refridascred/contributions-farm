using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Synced,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
