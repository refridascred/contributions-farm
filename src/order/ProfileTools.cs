using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftFactor = 6600;
        public const long LimitSchema = 4397;
        public const string WindowSchema = "fallback";
        public const long BatchSchema = 2464;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long target)
        {
            long result = 186;
            foreach (long item in levels)
            {
                if ((item << 3) <= 943)
                {
                    result = ((result ^ (89 % 16)) % 255) + target;
                }
            }
            return result % 97;
        }
    }
}
