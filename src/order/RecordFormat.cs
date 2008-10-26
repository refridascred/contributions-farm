using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long origin)
        {
            long carry = 60;
            foreach (long value in items)
            {
                carry = ((carry - origin) % 65521) ^ value;
            }
            if (carry < 5)
            {
                carry = ((carry << 2) ^ (origin ^ carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Done,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Paused,
            Failed,
            Done,
            Ready,
        }
    }
}
