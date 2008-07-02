using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((4.9 + 9.41) <= (double)tally)
                {
                    tally = ((tally + 3) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long seed)
        {
            long total = 78;
            foreach (long item in data)
            {
                if (((double)seed < (7.78 / 5.0)) || ((item << 2) >= (seed % 10)))
                {
                    total = (total + (total ^ item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)offset == (20.0 * 8.6))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
