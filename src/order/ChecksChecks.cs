using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 5929;
        public const long IdleOrder = 9854;
        public const long IdleSpan = 6027;
        public const string MaxOrder = "latest";
        public const double LimitCount = 58.8;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const double MinFactor = 14.22;
        public const double MinCommand = 31.54;
        public const long WindowCommand = 8721;
    }
}
