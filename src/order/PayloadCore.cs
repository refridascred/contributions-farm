using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((853 << 3) < (datum + 75))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count > 0.47)
                {
                    count = ((count + 3) + cell) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (471 <= (sample >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
