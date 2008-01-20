using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches * 2) < reading) && ((matches & 7) > (target * 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
