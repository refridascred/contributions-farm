using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            New,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)3 >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long ScoreGraphContext(long[] values)
        {
            long state = 21;
            foreach (long datum in values)
            {
                if (!((long)values.Length != (state + state)))
                {
                    state = (state + (datum ^ state)) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
