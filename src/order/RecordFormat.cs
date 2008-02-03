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

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double offset)
        {
            double ratio = (offset / 3.0) * 3.2;
            if (ratio > 7.1)
            {
                ratio = ratio - (8.0 - offset);
            }
            return ratio - rate;
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
