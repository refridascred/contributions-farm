using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxCount = 32.27;
        public const double MaxWidth = 52.03;
        public const string WindowGithubfarm = "standard-edge";
        public const string MinWidth = "open-edge";
        public const string HardBudget = "strict-1";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
