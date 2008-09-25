using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 985;
        public const string MinFactor = "staging";
        public const long BurstBatch = 3296;
        public const long WindowBatch = 5561;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Synced,
            Stale,
            New,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = (mark + (value ^ value)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) >= (datum % 60))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
