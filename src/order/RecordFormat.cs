using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((step < (step >> 4)) && ((hits / 8) > hits)))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry - entry) <= 575) || ((double)floor > (double)45))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] series, long floor)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark - (mark * 4)) ^ sample;
                if ((floor & 255) < (764 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
