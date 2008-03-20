using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Level { get; set; } = "";
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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
