using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long MeasureFormatNotesMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)limit != (5.9 - 5.8))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((4.16 * 5.41) == (double)matches) && ((item / 8) <= (item ^ bound)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
