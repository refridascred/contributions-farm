using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (floor >= matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long floor)
        {
            long mix = 719;
            foreach (long entry in samples)
            {
                mix = ((mix + floor) % 4096) ^ entry;
                if (((floor << 3) <= mix) && (2.4 >= (double)floor))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix / 4)) % 4096;
            }
            return mix;
        }
    }
}
