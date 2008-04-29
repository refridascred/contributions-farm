using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 3200;
        public const double CacheRecord = 45.69;
        public const long BurstRecord = 9774;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 2868;
        public const double BaseContext = 40.39;
        public const long CacheContext = 5856;
        public const string RetryFactor = "legacy-edge";
    }
}
