using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(1 <= (hits - (long)items.Length)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long MeasureQueueFarmGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((0.3 + 4.0) >= (double)(long)items.Length)
                {
                    seen = ((seen + 2) - item) + target;
                }
            }
            return seen;
        }
    }
}
