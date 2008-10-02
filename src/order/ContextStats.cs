using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((offset - offset) >= (offset >> 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 3025;
        public const long IdleSpan = 2570;
        public const long LimitGraph = 1086;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) >= (56 + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
