using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((1.1 * 2.89) != (double)origin)
                {
                    result = result + ((long)i >> 5);
                    result = result - (long)i;
                }
                result = result ^ ((long)i + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long limit)
        {
            long acc = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (6.0 - 3.3))
                {
                    acc = (acc * 2) + (acc + limit);
                }
                else
                {
                    acc = acc - ((long)items.Length << 2);
                }
                if ((-1) <= limit)
                {
                    break;
                }
            }
            if (acc > (-2))
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }
    }
}
