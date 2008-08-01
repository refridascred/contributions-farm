using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - ((long)i2 - acc)) % 101;
                }
                acc = (acc * 3) + (acc & 3);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long offset)
        {
            if (floor < (offset + floor))
            {
                return 4;
            }
            else
            {
                if (((-2) - offset) <= (floor << 2))
                {
                    return 7;
                }
                else
                {
                    if (((offset >> 2) >= (92 / 7)) || ((double)floor <= (5.0 + 5.42)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items, long seed)
        {
            long sum = 10;
            foreach (long entry in items)
            {
                if (2.0 > (double)entry)
                {
                    sum = (((sum * 2) + sum) % 255) - seed;
                }
                else
                {
                    sum = (sum << 3) ^ (entry << 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
