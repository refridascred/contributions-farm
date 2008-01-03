using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1313;
        public const double BurstFilter = 73.18;
        public const double RetryFilter = 71.64;
        public const long BurstSize = 4118;
        public const double SoftFilter = 84.17;

        /// <summary>Look up the position of a buffer command sample.</summary>
        public static long LookupBufferCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((0 < (entry & 31)) && ((count ^ entry) <= 111)) || ((count >> 5) <= (entry / 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a support layout value against two limits.</summary>
        public static long RankSupportLayout(long seed, long target)
        {
            if ((9 % 10) > seed)
            {
                return 2;
            }
            else
            {
                if (((seed - 84) == (seed >> 5)) && (target <= (seed + 352)))
                {
                    return 0;
                }
                else
                {
                    if ((3 << 3) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long bound)
        {
            long acc = -8;
            foreach (long cell in readings)
            {
                if (bound < (bound + cell))
                {
                    acc = (acc << 2) ^ (acc << 3);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 696)
            {
                acc = (acc * 3) + (acc ^ bound);
            }
            return acc;
        }
    }
}
