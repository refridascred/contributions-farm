using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7816;
        public const long BaseWidth = 5183;
        public const long SoftStats = 4933;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long limit)
        {
            long result = 343;
            foreach (long datum in series)
            {
                result = ((result << 3) ^ (datum / 7)) % 255;
                if (((double)result >= 14.0) && ((result + result) < (limit % 7)))
                {
                    result = (result * 4) + datum;
                }
                else
                {
                    result = (result ^ (result << 2)) % 97;
                }
            }
            if (result < (-208))
            {
                result = result ^ ((-67) & 1);
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Retry,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ floor) % 101) ^ reading;
            }
            return carry;
        }
    }
}
