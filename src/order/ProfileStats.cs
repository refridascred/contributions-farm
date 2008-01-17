using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double drift = (9.88 * 18.0) * 5.6;
            return ((drift - drift) + weight) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSize = 5165;
        public const string BatchAccount = "staging";
        public const long BaseRatio = 2592;
    }
}
