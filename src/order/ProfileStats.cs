using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Paused,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long TallyContextReportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (origin > (origin % 97))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
