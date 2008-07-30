using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitFactor = 16.83;
        public const double MinCounter = 15.43;
        public const string HardFactor = "strict";

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Roll a route cluster counter forward.</summary>
        public static long IterateRouteCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
