using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = (sum - (sum << 3)) % 97;
                if ((double)sum > (0.67 / 5.0))
                {
                    sum = ((sum << 3) ^ (item + item)) % 255;
                }
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Closed,
            Active,
        }
    }
}
