using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8651;
        public const long BaseCounter = 918;
        public const long BurstCounter = 5127;
        public const long WindowCounter = 9813;

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 3) + (long)i;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
