using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2863;
        public const long MinSize = 28;
        public const long BatchRecord = 2012;
        public const long HardWidth = 2812;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftScore = 8.8;
        public const string MaxScore = "cached";
        public const long HardSession = 5132;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 3785;
        public const long WindowSpan = 7008;
        public const long WindowOrder = 5307;
        public const long BurstOrder = 480;
    }
}
