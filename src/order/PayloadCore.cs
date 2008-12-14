using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every queue order entry stays within the limit.</summary>
        public static bool GuardQueueOrderBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Done,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
