using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Closed,
            Synced,
            Pending,
            New,
        }

        /// <summary>Classify a cache batch pair into a bucket.</summary>
        public static long BucketCacheBatch(long offset, long target)
        {
            long diff = offset - target;
            if (target >= (diff + diff))
            {
                return 3;
            }
            else
            {
                if (((target * 2) > (1 + 541)) && ((1.5 + 4.0) > (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 3) >= (offset & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }
    }
}
