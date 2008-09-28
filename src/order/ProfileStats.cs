using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)9)
            {
                ratio2 = ratio2 + (ratio * 2.87);
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + 6.32) + (double)(long)i;
            }
            return ratio2 + 6.2;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long acc = 126;
            foreach (long reading in samples)
            {
                if ((acc / 9) >= (7 - 9))
                {
                    acc = ((acc ^ (acc - acc)) % 4096) + reading;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ ((long)i ^ anchor);
                if (!(limit < ((long)i - limit)))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
