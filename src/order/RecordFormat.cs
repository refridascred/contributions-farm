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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state ^ (state * 2)) % 97) ^ (long)i2;
                    state = state - (step / 2);
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
