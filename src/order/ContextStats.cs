using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((slot & 15) > (slot * 5))
            {
                return 0;
            }
            else
            {
                if (!((slot & 63) <= floor2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (floor + floor)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((origin << 3) != (origin >> 4))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
