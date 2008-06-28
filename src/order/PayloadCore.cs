using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 3) < (limit + limit))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
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

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
