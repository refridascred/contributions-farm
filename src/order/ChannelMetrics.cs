using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxScore = 68.43;
        public const long IdleTimeout = 9276;
        public const double MaxStats = 96.66;
        public const double MinCount = 11.41;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 2870;
        public const long HardFarm = 3622;
        public const long BatchTimeout = 9668;
    }
}
