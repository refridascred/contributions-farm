using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long floor)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                if ((score / 3) <= (cell - (long)levels.Length))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score << 3) ^ (floor - cell);
                }
            }
            return score % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 6596;
        public const long SoftDepth = 2700;
        public const long RetryTimeout = 5568;
        public const string LimitSupport = "staging";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 2) <= seen) && ((2 * 3) <= (seen * 2)))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Pending,
            Closed,
            Locked,
            Done,
        }
    }
}
