using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepFactor = 0.48;
        public const string DefaultCounter = "fallback-1";
        public const string BaseSpan = "latest-1";
        public const double IdleTimeout = 46.68;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
