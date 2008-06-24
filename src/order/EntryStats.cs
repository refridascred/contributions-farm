using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mark = -356;
            foreach (long entry in levels)
            {
                mark = (mark ^ (mark - entry)) % 101;
                mark = (mark + (mark & 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long TallyCommitsFarmMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (limit >= (limit ^ sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long SeekSupportGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
