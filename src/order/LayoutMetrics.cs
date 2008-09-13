using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Failed,
            Closed,
            New,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Dropped,
            Queued,
            Retry,
        }
    }
}
