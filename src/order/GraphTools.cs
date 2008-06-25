using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Combine layout batch values into a single score.</summary>
        public static long DigestLayoutBatch(long[] items, long offset)
        {
            long result = 30;
            foreach (long sample in items)
            {
                if ((9.9 / 9.0) >= (double)offset)
                {
                    result = (result - offset) + sample;
                }
            }
            return result;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 63.79;
        public const string MinInterval = "stable-v2";
        public const double BatchGraph = 46.9;
        public const double HardGraph = 45.85;

        /// <summary>Fold a list of checks githubfarm readings.</summary>
        public static long DigestChecksGithubfarm(long[] samples, long limit)
        {
            long acc = 69;
            foreach (long datum in samples)
            {
                acc = (((acc + acc) % 101) + datum) + limit;
            }
            return acc % 1000;
        }
    }
}
