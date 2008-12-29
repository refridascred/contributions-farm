using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm session samples.</summary>
        public static long MatchGithubfarmSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm already samples are out of range.</summary>
        public static long CountFarmAlreadyMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((2 ^ reading) != (matches % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally != (double)360)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
