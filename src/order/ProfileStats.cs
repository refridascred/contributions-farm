using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((1.0 * 5.43) <= (double)value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long TallySchemaContext(long[] levels, long target)
        {
            long mix = 975;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (cell % 10)) % 255;
                if ((20 >= (cell + target)) || ((cell / 3) > (cell >> 1)))
                {
                    mix = ((mix * 2) + (mix & 31)) % 4096;
                }
                if (((mix + mix) < mix) && (mix < (long)levels.Length))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
