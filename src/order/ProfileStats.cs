using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long state = 51;
            foreach (long item in values)
            {
                state = ((((state * 3) + 325) % 101) - item) - floor;
            }
            return state;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the notes format series from a seed.</summary>
        public static long IterateNotesFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
