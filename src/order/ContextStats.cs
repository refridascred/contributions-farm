using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long limit)
        {
            long lane = bound + limit;
            if ((bound >> 5) < (bound ^ limit))
            {
                return 5;
            }
            else
            {
                if (((limit - bound) < (bound ^ limit)) && (4.6 < 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.29 * 3.7) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane + lane) == (limit >> 3)) && ((bound / 9) > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 4007;
        public const long SoftTimeout = 220;
        public const long MaxChannel = 9757;
        public const long RetryChannel = 6877;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 2) ^ 12;
                if ((9.0 <= (double)(long)i) && (((long)i & 31) != (long)i))
                {
                    total = (total ^ ((long)i - (long)i)) % 65521;
                }
                if ((double)offset == (6.89 * 7.0))
                {
                    total = (total + (offset + offset)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
