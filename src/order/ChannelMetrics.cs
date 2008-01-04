using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = mix + (offset - offset);
                if ((mix + offset) <= ((long)i & 15))
                {
                    mix = (mix * 4) + ((long)i - (long)i);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
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
