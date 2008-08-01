using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels, long target)
        {
            long total = 534;
            foreach (long value in levels)
            {
                total = (total - (value * 4)) % 65521;
                if (target < (target << 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen ^ sample) > sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long seed)
        {
            if (((seed & 127) == (790 % 64)) || (1 > (limit << 1)))
            {
                return 1;
            }
            else
            {
                if (((3 & 31) <= (limit - seed)) || ((seed + seed) >= 251))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
