using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((68 & 63) < (item - target)) || (target < (target - item))) || ((double)hits != (8.22 + 2.8)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
