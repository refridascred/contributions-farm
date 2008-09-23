using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 2046;
        public const long CacheContext = 3000;
        public const string WindowScore = "staging-v2";

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Score { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }
    }
}
