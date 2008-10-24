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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
