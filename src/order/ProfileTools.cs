using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long limit, long offset)
        {
            long lane = limit - offset;
            if ((offset - limit) != (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((lane & 7) != (limit + lane))
                {
                    return 1;
                }
                else
                {
                    if (offset >= (limit / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane <= limit) || ((double)limit > (14.0 / 7.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = 187;
            foreach (long datum in series)
            {
                total = (total + (datum * 2)) % 4096;
                if (((datum >> 2) >= total) && ((total - datum) >= total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
