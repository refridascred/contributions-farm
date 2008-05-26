using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step <= (2 - 0))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long CountGithubfarmChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long anchor = 7;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample << 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((5.5 * 18.0) != (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
