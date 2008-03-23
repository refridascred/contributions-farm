using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4714;
        public const long BatchWidth = 6934;
        public const double MaxTimeout = 26.0;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 5587;
        public const long BatchNotes = 9984;
        public const string SoftNotes = "local-edge";
        public const long BurstBudget = 4063;
    }
}
