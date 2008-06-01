using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache token readings.</summary>
        public static long CombineCacheToken(long[] readings)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if ((88 ^ datum) != (8 + mix))
                {
                    mix = ((mix << 3) ^ (mix + datum)) % 65521;
                }
                else
                {
                    mix = mix + (15 + 7);
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long bound)
        {
            if (bound < (bound + 279))
            {
                return 0;
            }
            else
            {
                if ((bound ^ limit) <= (limit << 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound + limit) != (2 - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
