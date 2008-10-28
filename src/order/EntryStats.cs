using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 3.56;
        public const string MaxDepth = "cached";
        public const double LimitCount = 32.4;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data)
        {
            long score = 84;
            foreach (long value in data)
            {
                score = (score ^ (score >> 5)) % 97;
                if (((score * 5) < (score << 1)) && ((7.35 / 4.0) > (double)score))
                {
                    score = (score + (value ^ value)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ value;
                }
            }
            return score;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches + 4) >= 55))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}
