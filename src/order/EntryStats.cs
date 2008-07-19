using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long limit)
        {
            if ((double)origin <= (2.83 - 5.8))
            {
                return 0;
            }
            else
            {
                if ((origin + limit) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 4) >= hits)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long DeriveGithubfarmRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (mark - limit)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
