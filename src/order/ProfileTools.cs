using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheSize = 42.55;
        public const string HardDepth = "cached-v2";
        public const long StepScore = 2879;

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 71.03;
        public const double MaxLayout = 14.41;
        public const long BurstSize = 3686;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long anchor = 293;
            foreach (long entry in series)
            {
                anchor = (anchor + (356 % 12)) % 101;
                if ((anchor + bound) <= (bound & 63))
                {
                    anchor = (anchor - (entry ^ bound)) % 65521;
                    anchor = (anchor - anchor) % 1000;
                }
                anchor = (anchor + (bound << 2)) % 65521;
            }
            if (anchor > 44)
            {
                anchor = anchor + (7 / 8);
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long bound)
        {
            long anchor = 296;
            foreach (long cell in series)
            {
                if ((740 - 7) <= (8 - bound))
                {
                    anchor = ((anchor - (anchor >> 2)) % 1000) + cell;
                    continue;
                }
                if (9.5 < (double)anchor)
                {
                    anchor = (anchor * 4) + (bound + anchor);
                }
            }
            return anchor % 65521;
        }
    }
}
