using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long MeasureClusterSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell + count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches farm readings.</summary>
        public static long DigestBatchesFarm(long[] values, long limit)
        {
            long anchor = 108;
            foreach (long sample in values)
            {
                anchor = ((anchor << 3) ^ (sample + limit)) % 4096;
                anchor = ((anchor * 4) + (limit % 8)) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of route cache readings.</summary>
        public static long PairRouteCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
