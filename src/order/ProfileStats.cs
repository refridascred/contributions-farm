using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.38 * 11.0) < (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double scale = offset * 5.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (rate * 2.0)) + (double)(long)i;
            }
            return scale + (scale * 3.3);
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - limit) != (6 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit + 16) <= (limit & 255))
                {
                    return 6;
                }
                else
                {
                    if (((origin / 7) < (origin << 3)) && ((726 + limit) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (960 <= (limit % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
