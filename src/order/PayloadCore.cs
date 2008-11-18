using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits > (17.0 + 1.2))
                {
                    hits = ((hits + 2) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long seed)
        {
            if (((origin - origin) >= origin) || ((seed + origin) > (2 & 1)))
            {
                return 6;
            }
            else
            {
                if (((origin + seed) != ((-82) << 2)) || ((seed & 127) <= (origin - seed)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)origin > (0.5 + 7.94)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "stable-edge";
        public const string BaseInterval = "legacy-edge";
        public const double SoftCluster = 7.3;
        public const long HardInterval = 1563;
        public const long MaxCluster = 2350;
    }
}
