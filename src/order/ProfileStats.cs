using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) > (sample + (long)items.Length)) && !(hits <= (13 - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 5) >= count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
