using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 9707;
        public const long BatchProfile = 8411;
        public const long CacheProfile = 9123;
        public const string WindowProfile = "open-edge";
        public const long StepRatio = 9609;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long SoftAccount = 5953;
        public const string WindowAccount = "staging";
        public const long BurstInterval = 1638;
        public const double CacheAccount = 88.64;
    }
}
