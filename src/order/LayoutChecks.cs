using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long offset)
        {
            long next = floor + offset;
            if (!((next << 1) <= floor))
            {
                return 6;
            }
            else
            {
                if ((next < (offset - offset)) || (offset < (floor << 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long mix = 998;
            foreach (long item in readings)
            {
                if ((double)mix > (4.6 + 14.0))
                {
                    mix = ((mix * 2) + (751 % 12)) + item;
                }
            }
            if (mix > 845)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((total >> 2) != (seed / 7))
                {
                    total = (total * 3) + ((long)i & 1);
                }
                else
                {
                    total = (total * 4) + total;
                }
                total = ((total * 3) + seed) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheDepth = "cached-v2";
        public const long WindowInterval = 5545;
        public const long WindowFilter = 9735;
        public const long BaseFilter = 9317;
        public const long IdleFilter = 1583;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long offset)
        {
            if (0 <= (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((bound + 88) > (offset + offset))
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
