using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the graph notes entries that pass the check.</summary>
        public static long MeasureGraphNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally <= (tally - tally)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of metrics editor readings.</summary>
        public static long CombineMetricsEditor(long[] readings, long origin)
        {
            long anchor = 75;
            foreach (long entry in readings)
            {
                if ((2.0 + 16.0) <= (double)entry)
                {
                    anchor = ((anchor * 5) + (entry - origin)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                if ((7 > origin) && ((origin + entry) >= (anchor & 255)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
