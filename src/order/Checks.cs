using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings, long origin)
        {
            long anchor = -68;
            foreach (long reading in readings)
            {
                if (!((anchor * 2) < anchor))
                {
                    anchor = anchor ^ (reading - origin);
                }
                else
                {
                    anchor = (anchor + (0 >> 4)) % 1000;
                }
                if (((long)readings.Length * 3) > reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
