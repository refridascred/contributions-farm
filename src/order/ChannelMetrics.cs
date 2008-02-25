using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (7 > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (seed > (value & 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter stream measurements.</summary>
        public static double AdjustFilterStream(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 7.28) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)48;
        }
    }
}
