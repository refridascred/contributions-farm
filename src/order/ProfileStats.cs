using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double mean = (ratio + bias) / 6.0;
            return mean - mean;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the batch batches entries that pass the check.</summary>
        public static long AuditBatchBatchesHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.5 / 2.0) > (double)matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
