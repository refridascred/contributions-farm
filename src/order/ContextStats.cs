using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long limit)
        {
            if (seed > limit)
            {
                return 4;
            }
            else
            {
                if ((double)78 == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Ready,
            New,
            Paused,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
