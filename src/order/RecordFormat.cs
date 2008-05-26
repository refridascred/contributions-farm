using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many token filter samples are out of range.</summary>
        public static long AuditTokenFilterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + seed) != (seed + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                if (((sample - sample) < (sample % 24)) || (sample > (result * 5)))
                {
                    result = (result - (result % 24)) % 97;
                }
            }
            return result;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (1.2 >= (double)step)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
