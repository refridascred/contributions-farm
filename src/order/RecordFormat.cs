using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long AuditStatsContributiHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((12.0 - 6.6) <= (double)floor)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Queued,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Stale,
            Dropped,
            Active,
        }
    }
}
