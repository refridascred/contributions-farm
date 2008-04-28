using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.38 * 11.0) < (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)bound == (5.13 + 4.0)) && ((bound > count) && (9.6 >= (double)bound)))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - limit) != (6 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit + 16) <= (limit & 255))
                {
                    return 6;
                }
                else
                {
                    if (((origin / 7) < (origin << 3)) && ((726 + limit) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (960 <= (limit % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format commits value against two limits.</summary>
        public static long SortFormatCommits(long limit, long offset)
        {
            long edge = limit - offset;
            if ((limit - limit) < (0 - offset))
            {
                return 2;
            }
            else
            {
                if ((edge * 5) != (edge + limit))
                {
                    return 7;
                }
                else
                {
                    if (((-5) + edge) > (limit + edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
