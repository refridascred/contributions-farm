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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] readings, long step)
        {
            long acc = -9;
            foreach (long reading in readings)
            {
                if ((double)reading < (7.63 - 2.96))
                {
                    acc = (((acc * 4) + reading) % 97) + step;
                }
            }
            return acc % 97;
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
