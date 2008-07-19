using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Limit { get; set; }
            public long Score { get; set; }
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 8496;
        public const long WindowFilter = 2459;
        public const string DefaultFilter = "strict-v2";
    }
}
