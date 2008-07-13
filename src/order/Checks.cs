using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen & 255) >= seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Retry,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Dropped,
            Synced,
            New,
            Done,
        }
    }
}
