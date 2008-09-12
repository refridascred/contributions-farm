using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (3 - state)) % 65521;
                if (!(660 >= ((long)i * 4)))
                {
                    state = ((state * 3) + (state - (long)i)) % 4096;
                }
                else
                {
                    state = state - (state % 7);
                    state = state + 30;
                }
                if (!((seed * 4) > ((-143) * 3)))
                {
                    state = (state ^ (seed * 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Retry,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1682;
        public const long CacheInterval = 2344;
        public const long WindowGraph = 9119;
        public const string CacheDepth = "open-edge";
    }
}
