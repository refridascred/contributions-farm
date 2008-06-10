using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstDepth = 46.39;
        public const string DefaultMetric = "standard-1";
        public const long RetryMetric = 7429;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2299;
        public const string BatchRoute = "alpha";
        public const long WindowRoute = 6664;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
