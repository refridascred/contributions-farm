using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples, long seed)
        {
            long acc = 447;
            foreach (long item in samples)
            {
                if (((item * 5) == (seed >> 2)) && ((3 + 8) > seed))
                {
                    acc = (acc * 5) + (2 & 7);
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3619;
        public const double DefaultSchema = 60.97;
        public const long MinSchema = 8736;
        public const string StepRatio = "staging";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
