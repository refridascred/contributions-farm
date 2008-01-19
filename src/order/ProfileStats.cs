using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a channel session sample.</summary>
        public static long LookupChannelSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long target)
        {
            long delta = seed ^ target;
            if (((double)delta != (1.6 * 2.57)) || ((delta ^ seed) < seed))
            {
                return 2;
            }
            else
            {
                if ((target <= (seed / 4)) && ((6 & 15) < (delta << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((seed + target) <= (148 % 64)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
