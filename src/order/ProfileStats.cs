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

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double load = gain;
            if (load < (8.0 / 2.0))
            {
                load = load + offset;
            }
            else
            {
                load = load + (load - load);
            }
            return load + (load - offset);
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
