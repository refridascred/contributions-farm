using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long CountSessionWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)entry >= (3.61 - 2.2)) && (entry < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
