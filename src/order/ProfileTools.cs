using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of account format readings.</summary>
        public static long TallyAccountFormat(long[] values, long origin)
        {
            long anchor = 83;
            foreach (long reading in values)
            {
                if (origin < (anchor & 7))
                {
                    anchor = (anchor + anchor) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (6.4 < (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long acc = 757;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (8 - acc))
                {
                    acc = acc + floor;
                    acc = acc + (value * 3);
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ (value + value)) % 255) ^ (long)i;
                }
                acc = (acc << 3) ^ (floor / 6);
            }
            if (acc > 0)
            {
                acc = (acc - 86) % 65521;
            }
            return acc;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinScore = 4668;
        public const string CacheLevel = "alpha-edge";
        public const long BaseSpan = 2933;
        public const long DefaultScore = 2279;
    }
}
