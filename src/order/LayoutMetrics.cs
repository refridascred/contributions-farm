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

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
