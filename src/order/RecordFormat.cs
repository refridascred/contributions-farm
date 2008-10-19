using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value / 6) > bound)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + span) + (double)(long)i) + bias;
            }
            return load + (double)89;
        }
    }
}
