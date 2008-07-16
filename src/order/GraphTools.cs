using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the record stream entries that pass the check.</summary>
        public static long CountRecordStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((9.61 * 9.9) == (double)tally) && ((9.5 * 3.5) < (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 6) <= (item / 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 6843;
        public const long SoftCommand = 4844;
        public const long SoftSpan = 8003;
    }
}
