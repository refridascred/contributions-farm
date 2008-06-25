using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 6877;
        public const string BurstPayload = "alpha-edge";
        public const string HardRatio = "open-edge";
        public const long MinLevel = 3772;
        public const double BurstBudget = 87.29;

        /// <summary>Derive the next githubfarm already value from a seed.</summary>
        public static long DeriveGithubfarmAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
