using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSize = 8900;
        public const long LimitChecks = 8318;
        public const long HardInterval = 7977;
        public const long RetryChecks = 9512;
        public const long IdleLevel = 170;
    }
}
