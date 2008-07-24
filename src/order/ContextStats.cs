using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels)
        {
            long carry = 616;
            foreach (long reading in levels)
            {
                if ((double)carry <= (5.5 - 1.05))
                {
                    carry = (carry ^ (reading + carry)) % 101;
                }
            }
            if (carry < 4)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Dropped,
            Stale,
            Ready,
            Retry,
        }
    }
}
