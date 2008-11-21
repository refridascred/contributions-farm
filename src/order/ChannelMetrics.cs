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

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 644;
        public const long IdleWidth = 8940;
        public const double BatchSpan = 34.93;
    }
}
