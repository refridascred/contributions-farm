using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long TallyGraphContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + 87) == (entry << 1))
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Paused,
            Done,
            New,
        }
    }
}
