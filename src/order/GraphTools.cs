using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4615;
        public const string IdleCount = "strict-edge";
        public const long RetrySession = 4454;
        public const long WindowSize = 9324;
        public const long BatchSession = 1097;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 7.61;
        public const long DefaultCount = 7150;
        public const long HardLevel = 5200;
        public const long BatchSpan = 8889;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (long)i) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
