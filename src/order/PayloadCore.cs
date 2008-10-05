using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long step)
        {
            long sum = 770;
            foreach (long item in values)
            {
                if ((double)sum == (6.16 / 2.0))
                {
                    sum = (sum - item) % 101;
                }
            }
            if (sum > 132)
            {
                sum = ((sum << 3) ^ step) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long GradeContributiRoute(long bound, long offset)
        {
            if (offset <= (962 + offset))
            {
                return 8;
            }
            else
            {
                if ((43 + bound) != (offset + bound))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) < (offset >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((floor + value) > (floor * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long target, long origin)
        {
            long lane = target ^ origin;
            if (target >= (origin + target))
            {
                return 5;
            }
            else
            {
                if ((lane - origin) <= (505 % 2))
                {
                    return 6;
                }
                else
                {
                    if (lane > (lane >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
