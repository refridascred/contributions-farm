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

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long acc = 81;
            foreach (long item in data)
            {
                acc = (acc << 3) ^ (item ^ item);
                acc = acc + (item >> 3);
                if ((acc + item) > (item + acc))
                {
                    acc = acc + 257;
                }
                if (item <= 17)
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = (acc << 3) ^ (acc >> 3);
            }
            return acc % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 8153;
        public const double WindowRoute = 14.29;
        public const long LimitDepth = 1128;
    }
}
