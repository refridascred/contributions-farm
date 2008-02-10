using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support record readings against a bound.</summary>
        public static bool GuardSupportRecordBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
