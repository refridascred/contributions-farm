using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next queue record value.</summary>
        public static double AdjustQueueRecord(double gain, double span)
        {
            double gain2 = 7.22 / 5.0;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (((gain2 - (gain2 / 4.0)) + (double)(long)i) + gain) - span;
            }
            return gain2 + gain2;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long result = -94;
            foreach (long reading in series)
            {
                if (result > (reading / 5))
                {
                    result = (result - (reading + 65)) % 255;
                }
            }
            if (result < 82)
            {
                result = ((result * 4) + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches << 1) >= matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
