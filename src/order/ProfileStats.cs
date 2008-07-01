using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((double)carry >= (9.29 - 11.0)) || ((6 % 100) == (carry % 100)))
                {
                    break;
                }
                if ((double)carry <= (double)(long)i)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                    break;
                }
                carry = ((carry * 5) + (carry >> 4)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Stale,
            Done,
            Dropped,
        }
    }
}
