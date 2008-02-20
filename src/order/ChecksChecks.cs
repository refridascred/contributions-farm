using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order buffer samples.</summary>
        public static long CompareOrderBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
