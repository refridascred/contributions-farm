using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches > (double)target)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count cluster report pairs that satisfy a relation.</summary>
        public static long CompareClusterReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
