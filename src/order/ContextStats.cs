using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long floor)
        {
            if ((origin + 52) <= origin)
            {
                return 8;
            }
            else
            {
                if (!((double)floor < (8.3 - 0.6)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) == (origin + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (5.9 / 2.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double scale = (double)(978 + 394);
            if (scale >= (14.0 - 17.0))
            {
                scale = (scale - ratio) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - (double)21;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-edge";
        public const long CacheCluster = 7963;
        public const long CacheTimeout = 4282;
    }
}
