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

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
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
