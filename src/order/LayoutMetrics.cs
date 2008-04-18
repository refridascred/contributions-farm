using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultBudget = "local-v2";
        public const long DefaultCount = 7445;
        public const double CacheFormat = 39.55;
        public const long BurstWidth = 8942;
    }
}
