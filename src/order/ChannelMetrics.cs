using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + origin) > (29 >> 1))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit counter window readings against a rule.</summary>
        public static long MeasureCounterWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) < (datum ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
