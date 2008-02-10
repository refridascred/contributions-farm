using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a buffer layout reading by value.</summary>
        public static long LocateBufferLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((floor ^ datum) != (6 >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
