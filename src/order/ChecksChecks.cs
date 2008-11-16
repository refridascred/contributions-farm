using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema profile entries.</summary>
        public static long DigestSchemaProfile(long[] samples)
        {
            long sum = 73;
            foreach (long cell in samples)
            {
                sum = (sum << 2) ^ (cell + cell);
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Closed,
            Done,
        }
    }
}
