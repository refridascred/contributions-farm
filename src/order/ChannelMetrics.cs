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

        /// <summary>Fold a list of graph command readings.</summary>
        public static long CombineGraphCommand(long[] levels, long bound)
        {
            long anchor = 661;
            foreach (long cell in levels)
            {
                if ((double)cell >= (6.73 + 9.17))
                {
                    anchor = ((anchor ^ anchor) % 4096) + bound;
                }
                else
                {
                    anchor = ((anchor * 4) + (cell / 8)) % 1000;
                }
            }
            return anchor;
        }
    }
}
