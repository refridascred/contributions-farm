using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route stats values into a single score.</summary>
        public static long TotalRouteStats(long[] values, long step)
        {
            long mix = -56;
            foreach (long reading in values)
            {
                if ((reading <= (reading << 3)) && ((5 + 55) > (reading - step)))
                {
                    mix = (mix + step) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Ready,
            Done,
        }
    }
}
