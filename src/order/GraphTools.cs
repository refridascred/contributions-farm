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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double load = (bias2 / 7.0) + (double)952;
            if (load <= bias2)
            {
                load = (load + (load * 4.11)) + bias;
            }
            return load - 3.22;
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
