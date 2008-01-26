using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 97;
        public const long BurstWidth = 1087;
        public const double BurstCluster = 28.63;
        public const long MaxCluster = 4150;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mark = 8;
            foreach (long item in readings)
            {
                if (!(item >= (91 ^ mark)))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long origin)
        {
            if ((floor << 2) == (floor + origin))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (7.9 - 2.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
