using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepTimeout = "open-edge";
        public const long HardBuffer = 8898;
        public const string SoftWidth = "cached-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 76.03;
        public const long SoftSupport = 637;
        public const string HardInterval = "alpha";
        public const string MinSize = "legacy-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double HardCount = 7.14;
        public const double IdleWidth = 93.83;
        public const double MinLevel = 16.26;
        public const string CacheFormat = "legacy-1";
        public const string MaxFormat = "primary-edge";
    }
}
