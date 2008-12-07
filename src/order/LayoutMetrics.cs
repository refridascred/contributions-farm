using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) > tally) && (((0.31 / 3.0) > (double)tally) || ((entry - (long)samples.Length) <= (entry * 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
