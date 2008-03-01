using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long CountGraphStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length & 15) != (706 / 2))
                {
                    seen = ((seen + 2) - datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm token value against two limits.</summary>
        public static long SortGithubfarmToken(long origin, long offset)
        {
            if ((offset ^ 48) >= (offset & 1))
            {
                return 0;
            }
            else
            {
                if (((origin >> 1) > (offset / 5)) || ((13.0 / 9.0) == (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (offset > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark * 3) + ((long)i & 127)) % 255) ^ (long)i2;
                }
                mark = (mark + ((long)i - offset)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Failed,
            Active,
            New,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            New,
            Ready,
            Stale,
            Active,
        }
    }
}
