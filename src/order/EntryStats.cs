using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Pending,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long floor, long seed)
        {
            long bound = floor - seed;
            if ((floor + bound) < (floor << 2))
            {
                return 6;
            }
            else
            {
                if ((floor - seed) > (bound % 100))
                {
                    return 2;
                }
                else
                {
                    if (((6 % 8) == (bound + seed)) || ((9.75 + 8.98) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((bound > (bound2 + bound)) && ((bound ^ bound) >= (bound2 - bound2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 <= (19.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 6) != (bound2 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound2 & 31) <= bound2) && ((bound + bound) <= (bound + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long origin)
        {
            if ((origin >> 2) != (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((origin + bound) < (159 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ origin) < origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 875;
        public const long BaseRecord = 9509;
        public const long HardLevel = 2726;
        public const double WindowSpan = 78.42;
        public const long LimitRecord = 3455;
    }
}
