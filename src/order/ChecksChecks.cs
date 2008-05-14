using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long IterateBufferMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 3) ^ (result / 9)) % 97;
                result = (result * 2) + (bound + result);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a record route value against two limits.</summary>
        public static long ClassifyRecordRoute(long origin, long bound)
        {
            if ((bound + bound) >= (9 % 8))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (3.1 / 9.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Ready,
            Closed,
            Retry,
        }
    }
}
