using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long floor)
        {
            if (1.0 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((-6) / 4) != (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if (((-4) + offset) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor & 1) >= floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long limit)
        {
            long anchor = 873;
            foreach (long entry in data)
            {
                if (18 <= (anchor * 5))
                {
                    anchor = ((anchor - (limit + limit)) % 4096) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}
