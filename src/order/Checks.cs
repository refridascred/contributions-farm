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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + anchor) < anchor)
                {
                    anchor = (anchor + ((long)i % 5)) % 1000;
                    anchor = anchor + (anchor >> 3);
                }
                if (((long)i & 63) == (3 % 3))
                {
                    anchor = (anchor ^ (long)i) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

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
