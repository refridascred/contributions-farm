using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheLevel = "standard-v2";
        public const long CacheFactor = 5601;
        public const long SoftLevel = 6966;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cluster batches pair into a bucket.</summary>
        public static long BucketClusterBatches(long origin, long origin2)
        {
            long cur = origin - origin2;
            if (3 > (origin2 + origin2))
            {
                return 6;
            }
            else
            {
                if ((7.4 - 7.03) > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin2 + cur) <= (origin2 % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every metric order entry stays within the limit.</summary>
        public static bool CheckMetricOrderRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)anchor >= (double)669)
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
