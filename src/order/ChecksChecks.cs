using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long mix = 236;
            foreach (long datum in values)
            {
                if (((8 >> 4) > (mix >> 1)) || (66 <= (mix << 1)))
                {
                    break;
                }
                if (((long)values.Length + mix) > (mix % 8))
                {
                    mix = (((mix << 3) ^ (long)values.Length) % 101) ^ datum;
                }
            }
            return mix;
        }
    }
}
