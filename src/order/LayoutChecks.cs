using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer contributi pair into a bucket.</summary>
        public static long GradeBufferContributi(long step, long origin)
        {
            long gap = step - origin;
            if ((gap / 3) > ((-22) - 2))
            {
                return 7;
            }
            else
            {
                if ((double)step < (3.21 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 2) < 741)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - step) == (661 >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (764 & 63)) % 97;
                if ((double)state < (5.5 + 6.4))
                {
                    state = (state - ((-654) << 1)) % 4096;
                }
                state = ((state << 3) ^ target) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSpan = 1254;
        public const string DefaultToken = "alpha-v2";
        public const long CacheSize = 6618;
        public const long CacheSpan = 5536;
        public const string BatchToken = "local-v2";

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((double)offset >= (19.0 * 1.44))
            {
                return 5;
            }
            else
            {
                if ((bound * 3) == (offset & 127))
                {
                    return 1;
                }
                else
                {
                    if (!((bound - limit) < (bound >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit >= (offset / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
