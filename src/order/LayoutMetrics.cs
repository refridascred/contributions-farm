using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count >= (3.0 / 7.0)) || (count < cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up layout profile samples.</summary>
        public static long OverlapLayoutProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally == (3.0 + 5.28)) && ((20.0 + 7.0) < (double)seed))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
