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

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double gain2 = (double)(-609) * 10.0;
            if (gain2 <= (double)17)
            {
                gain2 = (gain2 + (double)5) - offset;
            }
            return gain2 + (gain - gain2);
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

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (bound + mix)) % 1000;
                mix = (mix * 3) + ((long)i ^ mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
