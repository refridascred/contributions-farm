using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the stats buffer series from a seed.</summary>
        public static long StepStatsBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i > (857 % 16)) && ((1.0 * 20.0) > (double)bound)))
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count >= (double)offset)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
