using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5877;
        public const long LimitWidth = 7224;
        public const string BaseFormat = "strict";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
