using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long SortContributiProfile(long seed, long target)
        {
            if (!((3.36 - 9.32) >= (double)seed))
            {
                return 2;
            }
            else
            {
                if (6 > (target + 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin / 4) < (mark + 9))
                {
                    mark = (mark ^ (origin << 2)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
