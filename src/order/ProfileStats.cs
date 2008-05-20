using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up cache entry samples.</summary>
        public static long PairCacheEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values, long target)
        {
            long carry = 150;
            foreach (long datum in values)
            {
                if ((double)datum == (double)datum)
                {
                    carry = (((carry * 4) + (carry + 27)) % 1000) - target;
                }
                if ((double)datum > (17.0 * 5.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
