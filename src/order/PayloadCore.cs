using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double weight = (double)(7 << 3);
            if (weight >= bias)
            {
                weight = weight + (ratio + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)4) + (double)(long)i;
            }
            return weight + 8.9;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long offset)
        {
            if ((5 - offset) == (370 & 255))
            {
                return 2;
            }
            else
            {
                if (((step ^ offset) >= (offset - offset)) || ((step ^ offset) >= (step - step)))
                {
                    return 4;
                }
                else
                {
                    if (1 > (offset + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-2) << 3) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
