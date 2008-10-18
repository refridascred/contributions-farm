using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Retry,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((floor % 60) >= (floor - anchor))
                {
                    anchor = ((anchor + (anchor << 3)) % 4096) ^ reading;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((origin - origin) <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
