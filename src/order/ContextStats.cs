using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long floor, long offset)
        {
            if (floor < (offset * 3))
            {
                return 1;
            }
            else
            {
                if (92 < (floor << 1))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Retry,
            Locked,
            Queued,
            Done,
        }
    }
}
