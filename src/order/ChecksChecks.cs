using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a queue channel reading by value.</summary>
        public static long LocateQueueChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (((total * 3) + ((long)i + total)) % 4096) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
