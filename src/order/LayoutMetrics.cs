using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools notes counter forward.</summary>
        public static long IterateToolsNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ state) % 101;
                state = (state * 4) + 381;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
