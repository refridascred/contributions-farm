using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((4.0 / 8.0) > (double)value))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long bound)
        {
            long anchor = 228;
            foreach (long datum in samples)
            {
                if ((bound + 80) >= (239 << 2))
                {
                    anchor = (((anchor << 2) ^ (long)samples.Length) % 255) ^ datum;
                }
                if ((anchor >> 1) == (35 + anchor))
                {
                    break;
                }
            }
            if (anchor > 78)
            {
                anchor = anchor + (bound - bound);
            }
            return anchor % 65521;
        }
    }
}
