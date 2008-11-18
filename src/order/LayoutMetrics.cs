using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardCount = 4405;
        public const long BurstAlready = 460;
        public const double IdleFactor = 47.48;
        public const string SoftAlready = "latest-edge";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
