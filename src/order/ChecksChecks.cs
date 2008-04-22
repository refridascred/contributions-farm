using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2178;
        public const long WindowAccount = 2734;
        public const long LimitAccount = 3992;
        public const long SoftAccount = 8724;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 44.71;
        public const string BaseInterval = "standard-edge";
        public const long MinWidth = 1496;
    }
}
