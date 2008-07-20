using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long total = 8;
            foreach (long datum in values)
            {
                if ((9.0 * 8.3) > (double)total)
                {
                    total = total - (datum * 3);
                }
            }
            if (total > 81)
            {
                total = (total - (total - 16)) % 101;
            }
            return total;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long seed)
        {
            if (((seed % 8) > ((-9) - 967)) && ((double)seed <= (double)target))
            {
                return 4;
            }
            else
            {
                if ((double)target > (12.0 * 5.5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values, long origin)
        {
            long mark = 860;
            foreach (long item in values)
            {
                mark = (((mark + mark) % 101) - item) - origin;
                if ((813 > (811 - mark)) || ((double)mark == (8.8 * 5.8)))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 2048;
        public const long DefaultRatio = 2750;
        public const long HardFarm = 7199;
        public const long WindowDepth = 9821;
        public const long CacheInterval = 9404;
    }
}
