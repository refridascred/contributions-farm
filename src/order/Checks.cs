using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window schema samples are out of range.</summary>
        public static long MeasureWindowSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 1) > (seen / 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 975;
        public const long MaxCounter = 1289;
        public const long CacheCounter = 434;
        public const string DefaultCounter = "local-v2";

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Queued,
            Paused,
            Dropped,
            Draft,
        }
    }
}
