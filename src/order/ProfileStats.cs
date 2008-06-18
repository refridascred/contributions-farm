using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstLevel = 21.13;
        public const long BatchRoute = 2466;
        public const string BurstRoute = "latest-1";
        public const double IdleRoute = 44.79;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum ^ (86 / 9)) % 255) ^ reading;
            }
            return sum;
        }
    }
}
