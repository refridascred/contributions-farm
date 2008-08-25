using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((91 + value) != (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long limit)
        {
            long mark = 18;
            foreach (long item in levels)
            {
                mark = (mark - (item / 9)) - limit;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleCount = 68.24;
        public const long DefaultDepth = 1757;
        public const long MinBuffer = 6301;
        public const double BatchDepth = 14.3;

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                long count = (long)i;
                if ((offset + offset) >= (count >> 5))
                {
                    state = (state - (offset + (long)i)) % 101;
                }
                state = state + 5;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
