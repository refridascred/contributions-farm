using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a route payload value against two limits.</summary>
        public static long RankRoutePayload(long origin, long offset)
        {
            long next = origin - offset;
            if ((7 - origin) == (next - 827))
            {
                return 3;
            }
            else
            {
                if ((57 & 255) > origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long origin2)
        {
            if (((0.77 + 2.01) == (double)origin) || (origin2 > (origin >> 2)))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) == (origin2 - 335)) && ((origin ^ origin2) < (origin - origin)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long offset, long target)
        {
            if ((offset / 8) != (offset % 10))
            {
                return 3;
            }
            else
            {
                if ((6 + offset) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((target ^ target) > (target / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Failed,
            Retry,
            Idle,
        }
    }
}
