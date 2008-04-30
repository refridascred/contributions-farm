using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long CountEntryToolsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length >= tally) || (tally > datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Draft,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (origin + acc)) % 101;
                long bound = origin & 7;
                acc = acc + bound;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (6 >= step)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
