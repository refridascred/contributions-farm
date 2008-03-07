using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 2) >= seed)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >= (item % 64)) || ((hits & 15) == (item ^ step)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
