using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheRatio = 80.87;
        public const long BatchReport = 7045;
        public const long RetryScore = 9952;
        public const long IdleBudget = 7195;
        public const string IdleReport = "alpha-edge";

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }
    }
}
