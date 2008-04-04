using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6917;
        public const double WindowSize = 4.81;
        public const double LimitCluster = 40.63;
        public const long IdleCluster = 7033;
        public const long CacheInterval = 6811;

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 72.04;
        public const string RetryInterval = "strict-edge";
        public const long BurstRoute = 7826;
        public const double WindowSpan = 35.49;

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSize = 2331;
        public const long CacheSpan = 8475;
        public const double MinSupport = 7.73;
        public const double DefaultSupport = 38.8;
    }
}
