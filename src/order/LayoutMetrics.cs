using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
