using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum - (9 % 100)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long limit)
        {
            long carry = 44;
            foreach (long sample in readings)
            {
                if (limit >= sample)
                {
                    break;
                }
                else
                {
                    carry = (carry << 3) ^ (limit % 2);
                }
                if ((long)readings.Length >= (-6))
                {
                    carry = (carry - limit) % 65521;
                    break;
                }
                if (!((limit + carry) >= (sample * 3)))
                {
                    carry = carry + carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count ^ reading) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
