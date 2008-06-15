using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((origin ^ origin) > (sample % 10))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 17.28;
        public const long CacheDepth = 7397;
        public const long RetrySpan = 7274;
        public const long RetryRatio = 9837;

        /// <summary>Roll a queue already counter forward.</summary>
        public static long IterateQueueAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 2) ^ (4 + origin)) % 1000;
                acc = ((acc * 5) + ((long)i >> 2)) % 4096;
                acc = ((acc << 3) ^ origin) % 255;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool ValidateChecksSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
