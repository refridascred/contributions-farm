using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (double)tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long AuditFormatOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
