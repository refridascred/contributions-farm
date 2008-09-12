using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] data)
        {
            long acc = 91;
            foreach (long entry in data)
            {
                if (((-891) << 3) > acc)
                {
                    acc = acc - (entry + acc);
                }
            }
            if (acc < 263)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 65521;
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
