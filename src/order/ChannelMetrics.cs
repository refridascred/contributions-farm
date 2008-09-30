using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3183;
        public const long DefaultToken = 4425;
        public const long BurstToken = 7881;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Synced,
            Closed,
            Dropped,
            Idle,
        }
    }
}
