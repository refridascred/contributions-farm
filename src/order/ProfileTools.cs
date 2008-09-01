using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 6636;
        public const double MaxCluster = 74.4;
        public const long LimitCount = 2539;
        public const long CacheFactor = 9642;
        public const long LimitInterval = 645;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Queued,
            Ready,
        }
    }
}
