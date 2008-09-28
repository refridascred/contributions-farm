using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long target)
        {
            long anchor = 37;
            foreach (long entry in data)
            {
                if (!(((-3) % 60) <= (target / 7)))
                {
                    anchor = anchor ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Match up checks githubfarm samples.</summary>
        public static long CompareChecksGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ (acc % 8)) % 1000;
                acc = ((acc << 3) ^ (bound << 3)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Ready,
            Active,
            New,
        }
    }
}
