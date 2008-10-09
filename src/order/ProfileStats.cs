using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long offset)
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

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if ((mark & 7) < (sample - mark))
                {
                    mark = (mark - (mark + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((target + matches) < (target - 6)) && ((matches + target) == (cell >> 4))) && ((matches << 1) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (2 > (state * 5))
                {
                    state = (state * 5) + (state / 6);
                    continue;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
