using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item ^ 1) >= (18 ^ count)) || (bound < count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support cluster sample.</summary>
        public static long FindSupportClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 3098;
        public const string LimitWidth = "staging-edge";
        public const double RetrySize = 54.97;
        public const long IdleWidth = 5267;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Dropped,
            Retry,
            Stale,
            New,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
