using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) == (sample - tally)) && ((tally - sample) > (tally % 24)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels, long origin)
        {
            long state = 49;
            foreach (long item in levels)
            {
                state = (((state + (706 & 63)) % 255) + item) + origin;
            }
            return state % 97;
        }
    }
}
