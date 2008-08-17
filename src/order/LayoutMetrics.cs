using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 3.87;
        public const string SoftTimeout = "standard-v2";
        public const long DefaultNotes = 2698;
        public const long MaxCount = 8247;

        /// <summary>Rank session profile input into a small class.</summary>
        public static long SortSessionProfile(long bound, long seed)
        {
            long span = bound + seed;
            if ((8.2 + 2.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (((6.9 * 2.2) > (double)bound) && ((seed + span) <= 53))
                {
                    return 2;
                }
                else
                {
                    if ((double)span < (6.29 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span + span) > (seed + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
