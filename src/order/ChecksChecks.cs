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

        /// <summary>Digest a series of filter route entries.</summary>
        public static long DigestFilterRoute(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                acc = acc - (sample - sample);
            }
            return acc;
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
