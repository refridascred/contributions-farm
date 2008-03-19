using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepFactor = "latest-edge";
        public const long DefaultCount = 1937;
        public const long DefaultBuffer = 6718;
        public const double MaxBuffer = 17.32;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every cluster farm entry stays within the limit.</summary>
        public static bool VerifyClusterFarmBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
