using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
