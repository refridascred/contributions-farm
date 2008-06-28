using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stream editor samples.</summary>
        public static long WeighStreamEditor(long[] items, long floor)
        {
            long result = 5;
            foreach (long datum in items)
            {
                result = (result + (result << 1)) - datum;
            }
            if (result < 704)
            {
                result = (result << 3) ^ (floor % 24);
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > 16)
                {
                    tally = ((tally + 1) ^ cell) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((782 - hits) == (bound << 2)) || ((double)bound >= 3.2)) && ((double)240 < (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema commits sample.</summary>
        public static long LookupSchemaCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
