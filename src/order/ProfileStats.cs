using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long sum = 752;
            foreach (long sample in items)
            {
                sum = (sum + sample) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Idle,
            Paused,
            Synced,
        }
    }
}
