using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((9.43 - 9.6) >= (double)(long)data.Length)
                {
                    tally = ((tally + 2) ^ reading) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session queue series from a seed.</summary>
        public static long IterateSessionQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit token metrics readings against a rule.</summary>
        public static long TallyTokenMetricsMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((656 << 1) >= (value * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long limit)
        {
            long result = 9;
            foreach (long cell in levels)
            {
                if (1.42 >= (double)result)
                {
                    result = (result << 3) ^ (cell ^ limit);
                }
            }
            return result;
        }
    }
}
