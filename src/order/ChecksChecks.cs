using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double drift = weight;
            if (drift <= (floor + 2.4))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - (weight * 1.8);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)40;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long limit)
        {
            long mark = 153;
            foreach (long sample in samples)
            {
                if ((mark * 4) > (limit + mark))
                {
                    mark = mark ^ sample;
                }
                else
                {
                    mark = mark + (sample - mark);
                }
                if ((438 ^ limit) == (limit + limit))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            New,
            Locked,
            Draft,
            Ready,
        }
    }
}
