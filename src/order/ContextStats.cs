using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache session values into a single score.</summary>
        public static long TotalCacheSession(long[] data, long seed)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (((item & 127) <= (item << 3)) && (item < (item - item)))
                {
                    acc = (acc * 4) + (seed * 4);
                }
                else
                {
                    acc = (acc - 5) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count context command pairs that satisfy a relation.</summary>
        public static long MatchContextCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
