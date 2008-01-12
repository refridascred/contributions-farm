using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 63) >= offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading <= (reading >> 4)) && ((seen - (long)items.Length) <= (reading >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next order command value from a seed.</summary>
        public static long IterateOrderCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (total + total)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "strict-1";
        public const string MinBudget = "standard";
        public const long WindowWidth = 419;
        public const long DefaultRoute = 6861;

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
