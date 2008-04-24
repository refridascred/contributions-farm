using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long floor)
        {
            long prev = origin + floor;
            if (origin > prev)
            {
                return 3;
            }
            else
            {
                if (!(prev > (origin - prev)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((8.3 + 15.0) != (double)value)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches >= (1.9 - 5.68))
                {
                    matches = ((matches + 2) - cell) - limit;
                }
            }
            return matches;
        }
    }
}
