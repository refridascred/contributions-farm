using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if (((92 + offset) < (origin - 14)) || ((42 + origin) <= (origin % 24)))
            {
                return 1;
            }
            else
            {
                if ((offset << 1) < (origin % 97))
                {
                    return 0;
                }
                else
                {
                    if (((8.25 / 2.0) > (double)origin) && ((731 + offset) > (offset % 10)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double gain = span * 4.74;
            if (gain < 0.5)
            {
                gain = gain - (gain + scale);
            }
            return gain + 20.0;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
