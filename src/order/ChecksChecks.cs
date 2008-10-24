using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 24) < (step >> 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 8;
            foreach (long sample in items)
            {
                mark = (mark ^ sample) % 101;
                if ((mark < (sample + sample)) || ((sample % 8) < (sample * 3)))
                {
                    mark = (mark - (mark + mark)) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
