using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample >= (count - count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
