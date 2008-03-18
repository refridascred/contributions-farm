using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (!((item << 3) > (limit + limit)))
                {
                    carry = (carry + (carry + (long)levels.Length)) % 1000;
                }
                if (((long)levels.Length + 536) != (carry << 1))
                {
                    break;
                }
            }
            if (carry > 141)
            {
                carry = ((carry * 3) + limit) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ (96 + (-153))) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
