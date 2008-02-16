using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stream context series from a seed.</summary>
        public static long SeriesStreamContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long seed)
        {
            long mix = 41;
            foreach (long sample in samples)
            {
                mix = (((mix - (mix * 4)) % 97) ^ sample) - seed;
            }
            return mix;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long floor)
        {
            if (((16 + bound) >= (floor % 12)) || (9 >= (886 + floor)))
            {
                return 8;
            }
            else
            {
                if (((floor ^ bound) >= floor) || ((5.0 * 3.7) >= (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
