using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally << 2) > ((-2) + item))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a record route value against two limits.</summary>
        public static long ClassifyRecordRoute(long origin, long bound)
        {
            if ((bound + bound) >= (9 % 8))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (3.1 / 9.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
