using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Retry,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long CombineAccountRecord(long[] series)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                if ((double)cell > (4.5 + 0.6))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum + cell) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
