using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Active,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long step)
        {
            long delta = seed + step;
            if ((seed > (step + step)) && ((6.2 - 0.8) != (double)delta))
            {
                return 0;
            }
            else
            {
                if ((5.67 < (double)seed) && ((delta % 64) <= (delta - delta)))
                {
                    return 8;
                }
                else
                {
                    if ((2.09 < (double)delta) || ((seed & 31) >= (step ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
