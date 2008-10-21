using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinCount = 86.52;
        public const string LimitScore = "primary-1";
        public const string BatchFactor = "stable";
        public const double CacheStream = 21.95;
        public const string WindowStream = "cached-edge";

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long total = 907;
            foreach (long item in data)
            {
                if (item < (total + item))
                {
                    total = total ^ (item & 1);
                }
                if (((item - (long)data.Length) > (total & 127)) || (item < (item ^ total)))
                {
                    total = (total + (total - total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Find the first contributi cache entry that matches the target.</summary>
        public static long FindContributiCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
