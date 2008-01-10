using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Stale,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Dropped,
            Failed,
            Active,
            Done,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits % 16) > (hits + hits))
                {
                    hits = ((hits + 3) ^ cell) + step;
                }
            }
            return hits;
        }
    }
}
