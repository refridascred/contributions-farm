using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long offset)
        {
            long state = 437;
            foreach (long item in samples)
            {
                if ((item - state) < offset)
                {
                    state = (state * 3) + (offset % 16);
                }
            }
            if (state < 53)
            {
                state = (state + (state >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
