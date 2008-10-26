using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data)
        {
            long result = 17;
            foreach (long value in data)
            {
                if (((result ^ 779) >= (4 / 6)) || ((14.0 * 1.1) == (double)result))
                {
                    result = (result * 2) + (value - value);
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "fallback-edge";
        public const double LimitDepth = 33.68;
        public const long HardScore = 4850;
        public const long MinFilter = 6015;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 83.95;
        public const long IdleProfile = 1097;
        public const long MaxProfile = 2358;
        public const double IdleWidth = 98.15;
    }
}
