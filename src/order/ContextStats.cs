using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit githubfarm support readings against a rule.</summary>
        public static long CountGithubfarmSupportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >= (sample / 6)) && (((double)sample >= (7.5 + 1.3)) && ((sample / 8) >= (matches - sample))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of token payload readings.</summary>
        public static long FoldTokenPayload(long[] values, long step)
        {
            long score = 12;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((((score << 2) ^ (cell + 9)) % 4096) + (long)i) - step;
                }
                score = (score - 9) % 65521;
            }
            return score;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
