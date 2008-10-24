using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long BucketSchemaBuffer(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((bound2 ^ (-78)) == (76 & 31))
            {
                return 6;
            }
            else
            {
                if ((8 < (bound2 / 6)) && ((bound2 + offset) < (622 * 2)))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 ^ bound) > (offset * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - offset) > (bound2 ^ 50))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two tools profile measurements.</summary>
        public static double AdjustToolsProfile(double rate, double offset)
        {
            double scale = (rate + offset) / 2.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (6.6 * 19.0);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
