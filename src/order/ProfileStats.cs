using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long AuditGraphLayoutHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + target) != (target - 82)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (1.36 <= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Locked,
            Dropped,
            Draft,
        }
    }
}
