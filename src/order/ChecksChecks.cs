using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a token graph sample.</summary>
        public static long LookupTokenGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((67 % 5) >= count) || (0 < (count >> 3)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
