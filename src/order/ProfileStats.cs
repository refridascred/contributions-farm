using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long mark = 33;
            foreach (long value in levels)
            {
                if ((value <= (9 << 1)) && ((58 + value) != (target ^ value)))
                {
                    mark = (mark << 2) ^ mark;
                }
                if (!(value <= (mark + target)))
                {
                    mark = (mark - value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values)
        {
            long score = 404;
            foreach (long cell in values)
            {
                if (!((score - cell) >= (score + cell)))
                {
                    score = score + (cell >> 2);
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the token layout series from a seed.</summary>
        public static long IterateTokenLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((9.7 * 9.0) != (double)total) || ((double)seed == (4.17 - 1.84)))
                {
                    total = total ^ ((long)i ^ seed);
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 8153;
        public const double WindowRoute = 14.29;
        public const long LimitDepth = 1128;
    }
}
