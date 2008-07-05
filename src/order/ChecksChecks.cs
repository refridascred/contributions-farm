using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long SortToolsCache(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((floor << 3) < (gap << 1))
            {
                return 5;
            }
            else
            {
                if ((floor - floor2) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor2 >> 1) > (floor + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1139;
        public const long BaseCache = 1464;
        public const long StepSize = 8922;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
