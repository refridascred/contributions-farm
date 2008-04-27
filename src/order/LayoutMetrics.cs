using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cache layout entries.</summary>
        public static long TotalCacheLayout(long[] values)
        {
            long result = -429;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result + (result & 255)) % 255) + (long)i;
                }
                result = (result - reading) % 1000;
                if ((17.0 - 5.8) == (double)reading)
                {
                    break;
                }
            }
            if (result > 105)
            {
                result = result ^ (3 + result);
            }
            return result % 4096;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long bound)
        {
            long span = offset + bound;
            if ((double)bound != (double)133)
            {
                return 0;
            }
            else
            {
                if ((span / 8) <= (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (((bound & 7) > (span + span)) || (span >= (bound + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
