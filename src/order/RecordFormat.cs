using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes graph entries.</summary>
        public static long DigestNotesGraph(long[] data, long bound)
        {
            long carry = -94;
            foreach (long sample in data)
            {
                carry = (((carry << 3) ^ (sample - sample)) % 255) - bound;
            }
            if (carry > 972)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 101;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSpan = "cached-1";
        public const string LimitRecord = "open-v2";
        public const long IdleRecord = 8732;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 50;
        public const string BatchSize = "staging-edge";
        public const long BurstScore = 4695;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
