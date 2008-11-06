using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next stream schema value from a seed.</summary>
        public static long IterateStreamSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state + (state * 4)) + (long)i2;
                    state = ((state * 5) + (state >> 2)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
