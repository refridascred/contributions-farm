using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long score = -27;
            foreach (long sample in values)
            {
                if ((double)sample < (6.04 + 0.5))
                {
                    score = (score - score) % 1000;
                }
            }
            if (score < 63)
            {
                score = (score - score) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 7069;
        public const string BatchGithubfarm = "fallback";
        public const long MaxCount = 9103;
        public const long HardGithubfarm = 8620;

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((2.2 + 8.76) == (double)hits)
                {
                    hits = ((hits + 3) - reading) - step;
                }
            }
            return hits;
        }
    }
}
