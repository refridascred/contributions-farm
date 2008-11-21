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

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleTimeout = 6963;
        public const double MaxRatio = 64.49;
        public const long DefaultLevel = 1416;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 644;
        public const long IdleWidth = 8940;
        public const double BatchSpan = 34.93;
    }
}
