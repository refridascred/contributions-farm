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

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
