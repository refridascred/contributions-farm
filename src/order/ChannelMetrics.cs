using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 8.1) == (double)target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = sum ^ (floor & 3);
                    sum = ((sum * 3) + ((long)i2 + sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long seed)
        {
            long prev = origin + seed;
            if (!((204 - seed) > (88 - prev)))
            {
                return 2;
            }
            else
            {
                if (prev >= (seed + origin))
                {
                    return 7;
                }
                else
                {
                    if (((origin * 2) <= prev) || ((seed & 31) <= origin))
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
