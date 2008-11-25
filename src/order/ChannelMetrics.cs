using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxCount = 23.44;
        public const long HardChecks = 5692;
        public const long StepChecks = 4410;
        public const double CacheChecks = 88.84;

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheCount = "strict-v2";
        public const long StepSize = 7749;
        public const long DefaultRatio = 8543;
        public const double SoftFilter = 56.79;
        public const long MinFactor = 2196;
    }
}
