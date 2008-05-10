using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Done,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5350;
        public const long BatchDepth = 4751;
        public const long MaxTimeout = 5974;
        public const long BatchTimeout = 5386;

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double load = (double)(6 - 35);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + rate) + (double)(long)i) + floor;
            }
            return load + load;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Paused,
            Dropped,
            Stale,
        }
    }
}
