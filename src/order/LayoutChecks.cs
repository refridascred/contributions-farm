using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((389 / 2) < (tally - 1)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long seed)
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

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                if ((8.5 / 4.0) == (double)step)
                {
                    acc = acc + (reading - 131);
                }
            }
            if (acc > (-57))
            {
                acc = acc + (acc / 3);
            }
            return acc % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
