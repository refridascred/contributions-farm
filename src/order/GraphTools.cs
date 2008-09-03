using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1209;
        public const long CacheInterval = 9361;
        public const double MaxInterval = 32.08;
        public const long BatchSchema = 9826;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Paused,
            Ready,
            New,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
