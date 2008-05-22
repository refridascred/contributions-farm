using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((target / 7) <= 44))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - 61) == (1 << 2))
                {
                    count = ((count + 3) + datum) + offset;
                }
            }
            return count;
        }
    }
}
