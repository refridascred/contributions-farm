using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm metrics readings against a rule.</summary>
        public static long MeasureGithubfarmMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((-1) <= seen) && ((double)cell <= (1.19 * 18.0))) || ((13.0 + 3.91) == (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long anchor = 81;
            foreach (long sample in samples)
            {
                if ((double)anchor >= 18.0)
                {
                    anchor = anchor ^ (sample % 16);
                }
                if (((15 % 7) < anchor) || ((double)sample < (2.4 + 5.0)))
                {
                    break;
                }
            }
            if (anchor > (-565))
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long MeasureStatsContributiHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((50 ^ origin) > origin)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
