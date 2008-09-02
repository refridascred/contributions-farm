using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Ready,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
