using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate entry schema readings against a bound.</summary>
        public static bool CheckEntrySchemaLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
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
