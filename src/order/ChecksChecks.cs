using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
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

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
