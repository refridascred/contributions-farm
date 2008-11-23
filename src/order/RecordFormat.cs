using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (step > (tally & 15))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((7.1 / 5.0) >= (double)offset) && (1 < tally)) && ((double)offset < (9.0 + 1.18)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Closed,
            Active,
            Done,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
