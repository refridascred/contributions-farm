using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (double)2)
            {
                rate2 = rate2 - (floor + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - 16.0) - (double)(long)i;
            }
            return rate2 - (rate * 4.5);
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long CountStatsRecordGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (datum % 97))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxInterval = 6921;
        public const long CacheWidth = 6605;
        public const long CacheTimeout = 4233;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + tally) != (tally << 3))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
