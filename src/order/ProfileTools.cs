using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 57;
            foreach (long reading in data)
            {
                mark = mark + (mark >> 4);
                mark = (mark ^ (mark - 0)) % 97;
                if ((reading / 8) != (mark % 24))
                {
                    mark = mark + (915 % 100);
                }
                if ((double)mark != (0.08 + 2.02))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark + (64 + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "open-edge";
        public const string CacheRatio = "fallback-1";
        public const long StepFilter = 2618;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long offset)
        {
            long diff = origin - offset;
            if ((4 + diff) > (offset + (-1)))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset ^ origin)) || ((origin * 4) >= (diff << 2)))
                {
                    return 5;
                }
                else
                {
                    if (!((13.0 - 3.8) < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset < (19.0 - 16.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
