using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long ScoreNotesToken(long[] series)
        {
            long result = 428;
            foreach (long entry in series)
            {
                if (entry <= (result / 8))
                {
                    result = (result + ((long)series.Length & 7)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count the filter token entries that pass the check.</summary>
        public static long MeasureFilterTokenMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((8 - bound) <= (26 + seen)) || ((bound + entry) <= ((-6) << 3))) && (17 <= (bound + entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
