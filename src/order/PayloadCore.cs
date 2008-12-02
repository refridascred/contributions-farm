using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long floor)
        {
            long cur = seed + floor;
            if (floor < cur)
            {
                return 5;
            }
            else
            {
                if ((cur + floor) > (floor + cur))
                {
                    return 0;
                }
                else
                {
                    if ((floor > (cur * 4)) && ((double)cur >= (7.0 * 7.1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6 >> 3) < seed) && ((530 / 4) > cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
