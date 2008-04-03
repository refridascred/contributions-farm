using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the layout payload series from a seed.</summary>
        public static long SeriesLayoutPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                long lane = (target - 44) + (long)i;
                if ((target >= (lane + result)) && ((6.97 + 2.0) >= (double)(long)i))
                {
                    lane = (lane + (250 * 5)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSize = 955;
        public const double HardMetric = 95.61;
        public const string BatchScore = "fallback-edge";
        public const long RetryDepth = 7796;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                if (!((83 / 8) != (datum + mark)))
                {
                    mark = (mark * 3) + mark;
                }
                if ((double)datum != (double)4)
                {
                    mark = (mark + (mark / 6)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + (8 & 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count * 5) > (limit << 3)) || ((entry + count) > (count + 919))) || ((entry + entry) > (limit << 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
