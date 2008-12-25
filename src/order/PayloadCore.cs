using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)target >= (5.87 + 3.6))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6 / 9) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Locate a entry support reading by value.</summary>
        public static long LookupEntrySupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
