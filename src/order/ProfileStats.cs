using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4629;
        public const string MinReport = "cached-v2";
        public const long MaxReport = 6271;
        public const double LimitReport = 4.54;

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "open";
        public const long MaxRatio = 9191;
        public const long BaseCommand = 1639;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
