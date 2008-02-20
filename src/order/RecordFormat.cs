using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Done,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxInterval = 5663;
        public const long BurstBuffer = 5706;
        public const double SoftSize = 47.33;
        public const double BurstRatio = 70.97;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine metric batches values into a single score.</summary>
        public static long DigestMetricBatches(long[] series)
        {
            long acc = 643;
            foreach (long entry in series)
            {
                acc = (((acc * 4) + (acc << 3)) % 4096) + entry;
            }
            return acc % 1000;
        }
    }
}
