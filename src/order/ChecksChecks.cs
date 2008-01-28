using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long seed)
        {
            if (((origin + origin) < origin) && ((14.0 + 4.17) <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((4.6 / 2.0) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 12) >= (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (622 >= (count & 31))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
