using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long state = 6;
            foreach (long entry in items)
            {
                state = state - (entry + state);
                if (state < (state % 7))
                {
                    state = state - state;
                }
                else
                {
                    state = (state + (state % 10)) % 1000;
                }
                if ((double)entry > (double)state)
                {
                    state = (state * 4) + (entry + state);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
