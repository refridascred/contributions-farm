using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long offset)
        {
            if (3.2 >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((7.8 - 7.8) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings, long target)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (2.53 / 2.0)))
                {
                    acc = (acc - (acc * 5)) % 1000;
                    acc = (acc ^ target) % 65521;
                }
                if (((datum & 15) != (5 << 2)) || ((double)target > 2.2))
                {
                    acc = acc ^ (datum / 8);
                }
                else
                {
                    acc = ((acc * 3) + (acc % 10)) % 1000;
                }
            }
            if (acc > 847)
            {
                acc = acc + (long)readings.Length;
            }
            return acc;
        }

        /// <summary>Grade a buffer farm value against two limits.</summary>
        public static long ClassifyBufferFarm(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((origin / 9) > limit)
            {
                return 0;
            }
            else
            {
                if (((limit % 100) >= gap) && ((gap >> 5) != (gap + gap)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + origin) == (limit ^ gap))
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

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] values, long target)
        {
            long state = 1;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (target ^ sample)) % 101;
            }
            return state;
        }
    }
}
