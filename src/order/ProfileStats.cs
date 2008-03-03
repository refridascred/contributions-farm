using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up schema batch samples.</summary>
        public static long CompareSchemaBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
