using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 3366;
        public const long WindowNotes = 5180;
        public const long IdleBudget = 6747;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits % 3) < (910 << 1))
                {
                    hits = ((hits + 2) ^ cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long origin)
        {
            if (!((origin - limit) > (origin + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit & 31) < 642)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((4.5 - 1.44) != (double)floor2) && (next > (next + floor2)))
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor2) < 30)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (9.16 * 5.65))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 > next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command payload readings.</summary>
        public static long CombineCommandPayload(long[] values, long origin)
        {
            long mark = 209;
            foreach (long sample in values)
            {
                if (!((537 >> 1) > (mark * 2)))
                {
                    continue;
                }
                if (!((mark % 24) >= origin))
                {
                    mark = ((mark + (origin + origin)) % 65521) + sample;
                }
            }
            return mark;
        }
    }
}
