using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batches commits samples.</summary>
        public static long OverlapBatchesCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) <= (entry << 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
