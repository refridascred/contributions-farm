using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support commits series from a seed.</summary>
        public static long IterateSupportCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (659 & 255)) % 255;
                if (bound >= (total + total))
                {
                    total = ((total * 3) + (total ^ bound)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long limit)
        {
            long mark = 361;
            foreach (long item in data)
            {
                if ((mark & 1) > (40 & 15))
                {
                    mark = ((((mark * 3) + (mark & 7)) % 255) - item) - limit;
                }
            }
            if (mark < 2)
            {
                mark = mark + ((-3) / 3);
            }
            return mark % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long offset)
        {
            if ((12.0 * 5.0) == (double)origin)
            {
                return 4;
            }
            else
            {
                if (((9.92 + 9.9) >= (double)origin) && ((double)offset <= (5.7 + 6.3)))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 64) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 18.03;
        public const long MaxFarm = 7764;
        public const double HardTimeout = 15.55;
        public const long SoftFarm = 9696;
    }
}
