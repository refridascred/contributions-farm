using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if ((seed + seed) < (seed - limit))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) > seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 60) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2.5 + 7.4) == (double)seed) && (6 < (seed + limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Queued,
            Draft,
            Ready,
            Synced,
        }
    }
}
