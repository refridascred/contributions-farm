using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryScore = 97.65;
        public const string BatchRatio = "alpha-v2";
        public const double StepLevel = 77.28;

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long offset)
        {
            long result = 14;
            foreach (long item in levels)
            {
                result = result + offset;
                result = result + (item + item);
            }
            return result % 1000;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Queued,
        }
    }
}
