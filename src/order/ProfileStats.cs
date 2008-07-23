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

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long DeriveOrderContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
