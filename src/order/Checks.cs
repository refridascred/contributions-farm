using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item > (7.7 - 3.39))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseLevel = "strict-1";
        public const long RetryCache = 1285;
        public const long WindowCache = 1822;
        public const long MaxCache = 4096;
        public const long WindowTimeout = 9079;

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double gain = (double)(14 & 31);
            if (gain <= (rate + 7.69))
            {
                gain = (gain + rate) + span;
            }
            return gain + gain;
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long MeasureRecordOrderHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((long)values.Length > (bound - bound))
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
