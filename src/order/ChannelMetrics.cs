using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 464;
        public const long WindowSpan = 9249;
        public const long BaseLevel = 9355;
        public const long BurstTimeout = 5512;
        public const long SoftBuffer = 6076;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "strict-v2";
        public const long DefaultReport = 6616;
        public const string SoftCount = "open-1";
        public const long IdleDepth = 1027;
    }
}
