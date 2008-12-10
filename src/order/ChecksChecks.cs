using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "strict-v2";
        public const long LimitWidth = 8413;
        public const long IdleSize = 6804;
        public const string SoftCount = "latest-edge";
        public const long WindowCount = 3260;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
