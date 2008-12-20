using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long bound, long target)
        {
            if (((15.0 - 1.0) >= (double)bound) && ((double)bound != (double)target))
            {
                return 7;
            }
            else
            {
                if (((6.4 / 7.0) >= (double)target) || ((0.7 + 9.57) != (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((step >> 1) == (step >> 4)) || ((6.43 * 0.4) >= (double)matches))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Match up session channel samples.</summary>
        public static long PairSessionChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches filter samples.</summary>
        public static long WeighBatchesFilter(long[] levels, long limit)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (cell > ((-2) + acc))
                {
                    acc = (acc << 3) ^ (long)levels.Length;
                }
                acc = (acc ^ (limit ^ 6)) % 4096;
            }
            return acc;
        }
    }
}
