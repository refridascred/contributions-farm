using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3202;
        public const long HardCount = 4253;
        public const long MaxGithubfarm = 562;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
