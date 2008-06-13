using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings, long target)
        {
            long score = 75;
            foreach (long datum in readings)
            {
                score = (((score + (score / 2)) % 1000) - datum) + target;
            }
            return score % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 4) == (bound + reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count account stats pairs that satisfy a relation.</summary>
        public static long CompareAccountStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 4780;
        public const double BurstGithubfarm = 27.61;
        public const long IdleGithubfarm = 6014;
        public const long BaseWidth = 4568;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Paused,
            Closed,
        }
    }
}
