using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Locked,
            Idle,
            Ready,
        }

        /// <summary>Count the record checks entries that pass the check.</summary>
        public static long MeasureRecordChecksGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((-38) - sample) < sample)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                long tally = (long)i * 3;
                if (((mark ^ (long)i) < (tally % 2)) && ((0.94 - 2.6) >= (double)mark))
                {
                    tally = tally ^ ((long)i / 7);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (tally - tally))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count checks account pairs that satisfy a relation.</summary>
        public static long CompareChecksAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
