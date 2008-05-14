using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long anchor = 3;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (datum + anchor)) % 97;
                anchor = ((anchor * 5) + 0) % 1000;
            }
            return anchor;
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
