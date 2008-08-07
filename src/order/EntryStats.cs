using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 93.7;
        public const long MaxDepth = 6316;
        public const double HardFilter = 39.4;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9756;
        public const string StepProfile = "open-1";
        public const long MinCount = 1741;
        public const long MaxRatio = 700;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
