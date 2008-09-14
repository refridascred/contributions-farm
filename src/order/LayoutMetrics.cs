using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi graph samples.</summary>
        public static long FoldContributiGraph(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if (datum < (471 % 12))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - 6) < (entry + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
