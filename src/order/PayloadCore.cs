using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count cache batch pairs that satisfy a relation.</summary>
        public static long OverlapCacheBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long seed2)
        {
            if ((10.0 * 7.0) > (double)seed2)
            {
                return 4;
            }
            else
            {
                if (seed2 >= (seed - seed2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank payload window input into a small class.</summary>
        public static long GradePayloadWindow(long origin, long seed)
        {
            if (!(origin >= (origin + 908)))
            {
                return 6;
            }
            else
            {
                if (46 > (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((813 % 60) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >= (seed % 24)) && ((origin + origin) == (seed ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account report reading by value.</summary>
        public static long LocateAccountReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
