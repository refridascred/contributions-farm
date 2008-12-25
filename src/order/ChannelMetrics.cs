using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (434 <= (value - origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches ^ matches) < (cell / 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
