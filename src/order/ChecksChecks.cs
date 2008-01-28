using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a payload cache pair into a bucket.</summary>
        public static long RankPayloadCache(long offset, long seed)
        {
            if ((9.12 + 5.2) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset >= (13 % 100))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first profile queue entry that matches the target.</summary>
        public static long LookupProfileQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Synced,
            Retry,
        }
    }
}
