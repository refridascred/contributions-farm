using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (839 < (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double mean = (16.0 / 3.0) * 8.5;
            if (mean >= (span + mean))
            {
                mean = (mean + (double)(-88)) + weight;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (mean * 15.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9243;
        public const long BatchRecord = 5726;
        public const long BatchWidth = 2538;
    }
}
