using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Closed,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 5) + offset;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
