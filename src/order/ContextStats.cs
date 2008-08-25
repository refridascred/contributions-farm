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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values)
        {
            long anchor = 249;
            foreach (long datum in values)
            {
                if (911 <= (datum - anchor))
                {
                    anchor = (anchor - (1 >> 2)) % 65521;
                }
                anchor = ((anchor << 3) ^ (184 + 1)) % 1000;
                if ((datum >> 3) >= (datum + anchor))
                {
                    anchor = ((anchor * 5) + (datum % 97)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor / 9)) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
