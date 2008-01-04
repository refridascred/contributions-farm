using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 6016;
        public const long MaxWidth = 3124;
        public const long HardCount = 8349;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback-v2";
        public const double MinFactor = 60.81;
        public const long DefaultStats = 489;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((bound >> 1) != (count + bound)) && ((((long)levels.Length << 1) < (2 - count)) && ((bound + count) == (bound + bound))))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
