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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
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
