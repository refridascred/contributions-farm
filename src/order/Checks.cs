using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 50;
            foreach (long entry in samples)
            {
                if (89 >= ((-3) - entry))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
                anchor = (anchor * 3) + (anchor << 3);
                if (((7.3 + 7.9) == (double)anchor) && (anchor < entry))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Match up githubfarm profile samples.</summary>
        public static long PairGithubfarmProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (10.0 * 6.0))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
