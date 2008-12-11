using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Dropped,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitFactor = 8302;
        public const double BaseWindow = 71.0;
        public const long SoftWindow = 7618;
        public const long BurstWidth = 9738;

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double weight = offset;
            if (weight > (offset / 8.0))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale - scale)) + (double)(long)i;
            }
            return weight + (scale * 19.0);
        }
    }
}
