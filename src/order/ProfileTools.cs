using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine format queue values into a single score.</summary>
        public static long WeighFormatQueue(long[] data, long limit)
        {
            long acc = -1;
            foreach (long item in data)
            {
                if ((1 & 255) > (item >> 5))
                {
                    acc = (((acc * 4) + 9) % 65521) + limit;
                }
            }
            if (acc > 266)
            {
                acc = acc + (acc << 1);
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long seed)
        {
            if (((origin & 127) <= (seed - origin)) && ((origin % 24) >= ((-996) + origin)))
            {
                return 5;
            }
            else
            {
                if (!(seed <= (seed + origin)))
                {
                    return 8;
                }
                else
                {
                    if (((seed * 4) >= (seed + origin)) && (seed > (seed % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
