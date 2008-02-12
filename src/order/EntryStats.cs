using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a cluster already value against two limits.</summary>
        public static long SortClusterAlready(long floor, long offset)
        {
            if (!(591 < (floor & 127)))
            {
                return 8;
            }
            else
            {
                if ((55 * 3) < (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if (floor >= 596)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.4 + 9.2) == (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long offset)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if (7 < offset)
                {
                    mix = (mix - (item % 10)) % 1000;
                }
                if ((double)mix > (1.4 + 19.0))
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Rank format filter input into a small class.</summary>
        public static long ClassifyFormatFilter(long seed, long origin)
        {
            long step = seed ^ origin;
            if (((double)origin <= (20.0 * 3.5)) || ((origin - origin) < step))
            {
                return 3;
            }
            else
            {
                if (((-11) + (-93)) > step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "standard-1";
        public const double SoftSpan = 98.36;
        public const long RetryRecord = 5482;
        public const double DefaultRecord = 2.12;
        public const long BurstScore = 5403;
    }
}
