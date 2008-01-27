using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitFactor = 5381;
        public const long RetryGraph = 9202;
        public const long BurstGraph = 452;
        public const long BaseInterval = 3393;

        /// <summary>Look up the position of a editor account sample.</summary>
        public static long LookupEditorAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long seed)
        {
            long mark = 906;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 2) + ((long)i + seed)) % 101;
                    mark = (mark - (81 >> 2)) % 4096;
                }
                if (!(5.7 <= (double)mark))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + cell) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long origin, long limit)
        {
            long delta = origin - limit;
            if ((origin >> 3) == (origin + limit))
            {
                return 3;
            }
            else
            {
                if (!((delta / 2) > (limit * 2)))
                {
                    return 1;
                }
                else
                {
                    if (((origin ^ origin) <= delta) && (origin < 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + limit) <= 1)
                        {
                            return 0;
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
}
