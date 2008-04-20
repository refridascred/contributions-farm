using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Retry,
            New,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstCount = 5317;
        public const long SoftSchema = 6604;
        public const long MinSchema = 4555;
        public const long MaxSize = 8735;
        public const long BaseScore = 2926;
    }
}
