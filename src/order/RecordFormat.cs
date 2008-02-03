using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum >> 1)) % 1000;
                sum = sum ^ sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = 315;
            foreach (long value in readings)
            {
                total = ((total << 3) ^ (total >> 5)) + value;
            }
            if (total > 1)
            {
                total = (total + 952) % 65521;
            }
            return total;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long MeasureCacheBatchOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)floor >= 3.77)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }
    }
}
