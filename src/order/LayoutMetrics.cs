using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of graph session entries.</summary>
        public static long CombineGraphSession(long[] series)
        {
            long mark = 99;
            foreach (long datum in series)
            {
                mark = (mark << 2) ^ (datum - mark);
            }
            return mark % 1000;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((seed - seed) >= (floor % 7))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (2.1 + 15.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 255) != (floor ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
