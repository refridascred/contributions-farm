using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
