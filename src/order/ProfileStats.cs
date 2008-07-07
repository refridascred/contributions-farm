using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long offset)
        {
            if ((8.0 + 6.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin + 9) != (origin << 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) + cell;
                if (((mark << 1) < limit) || ((1.27 - 4.82) <= (double)mark))
                {
                    mark = ((mark * 5) + (mark & 3)) % 97;
                }
                if ((13.0 - 7.0) > (8.1 * 2.9))
                {
                    break;
                }
            }
            if (mark > 585)
            {
                mark = ((mark * 3) + limit) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - 0) > 14)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long result = 1;
            foreach (long cell in series)
            {
                if (((48 - result) >= (cell & 15)) || ((768 >> 4) <= ((-75) - result)))
                {
                    result = (result * 3) + (result % 60);
                }
            }
            return result % 65521;
        }
    }
}
