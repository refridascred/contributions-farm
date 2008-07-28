using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxTimeout = "open-v2";
        public const long HardSize = 2618;
        public const double HardGithubfarm = 3.48;
        public const double BurstGithubfarm = 55.66;
        public const double MaxLevel = 91.11;

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "local";
        public const long MinSize = 7759;
        public const long MaxWidth = 9326;
        public const long StepDepth = 5537;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = ((state + (limit ^ state)) % 65521) + sample;
            }
            if (state < 3)
            {
                state = ((state * 2) + (limit + (-83))) % 255;
            }
            return state;
        }
    }
}
