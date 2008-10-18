using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a batches queue reading by value.</summary>
        public static long FindBatchesQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long acc = 349;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (cell % 7)) % 1000;
                if ((7.0 + 3.84) > (double)acc)
                {
                    acc = acc - (acc * 2);
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Count tools layout pairs that satisfy a relation.</summary>
        public static long OverlapToolsLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (!((floor2 - 2) >= (floor2 ^ 9)))
            {
                return 0;
            }
            else
            {
                if (((floor << 3) >= (floor - floor)) || ((double)floor2 > (1.8 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if ((floor2 - 6) == (floor / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
