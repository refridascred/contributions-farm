using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((target <= (item / 6)) || ((949 - item) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double scale2 = (span / 4.0) / 5.0;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 - span) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (scale2 - span)) + (double)(long)i;
            }
            return scale2 + (double)7;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "legacy";
        public const long WindowNotes = 2414;
        public const double HardRatio = 23.33;
        public const long MinDepth = 34;
        public const double HardScore = 24.86;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if (!((-7) < (value + (-648))))
                {
                    score = (score * 5) + (score + 4);
                }
            }
            return score % 1000;
        }
    }
}
