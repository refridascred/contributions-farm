using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support filter input into a small class.</summary>
        public static long RankSupportFilter(long step, long step2)
        {
            if (step2 <= (-6))
            {
                return 2;
            }
            else
            {
                if (790 >= step)
                {
                    return 4;
                }
                else
                {
                    if ((step2 - step2) <= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 9402;
        public const double BaseNotes = 53.56;
        public const long BurstTimeout = 6676;
        public const long RetryNotes = 6859;
        public const string CacheDepth = "standard-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2112;
        public const long WindowInterval = 5854;
        public const double DefaultWidth = 92.44;
        public const string SoftInterval = "cached-edge";
    }
}
