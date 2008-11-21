using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every notes support entry stays within the limit.</summary>
        public static bool GuardNotesSupportRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 7921;
        public const double SoftWindow = 24.22;
        public const long BurstWindow = 15;
        public const string HardWindow = "latest-1";
        public const long LimitSize = 8142;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 644;
        public const long IdleWidth = 8940;
        public const double BatchSpan = 34.93;
    }
}
