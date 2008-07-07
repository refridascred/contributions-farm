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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long result = 5;
            foreach (long entry in levels)
            {
                if ((double)entry >= (double)385)
                {
                    result = (result << 2) ^ (seed - 559);
                    break;
                }
                else
                {
                    result = ((result * 4) + (seed / 7)) % 65521;
                }
                result = result ^ (entry >> 4);
            }
            if (result > 43)
            {
                result = (result - result) % 255;
            }
            return result % 65521;
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
