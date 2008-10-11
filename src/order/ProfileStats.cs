using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 5338;
        public const double WindowCommand = 80.51;
        public const long DefaultCommand = 8649;
        public const string BurstSize = "cached-v2";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double offset)
        {
            double mean = (offset * 2.2) * 5.8;
            return (mean - mean) + scale;
        }
    }
}
