using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data)
        {
            long total = 794;
            foreach (long entry in data)
            {
                if ((double)total >= 4.03)
                {
                    total = ((total << 2) ^ (entry - total)) % 255;
                }
                else
                {
                    total = total - entry;
                }
            }
            if (total < (-79))
            {
                total = total ^ (0 ^ total);
            }
            return total % 4096;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
