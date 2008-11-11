using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-v2";
        public const long HardInterval = 9008;
        public const string DefaultTools = "open-edge";
        public const string HardTools = "strict";
        public const string CacheTools = "strict-1";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Paused,
            New,
            Failed,
            Retry,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen == (double)(long)data.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
