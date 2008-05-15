using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the counter filter entries that pass the check.</summary>
        public static long TallyCounterFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches / 6) == (matches * 3))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if ((result % 5) <= sample)
                {
                    result = result - (83 / 8);
                }
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools order sample.</summary>
        public static long LocateToolsOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
