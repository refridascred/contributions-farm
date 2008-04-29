using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)tally == (3.0 - 2.0)) && (3.88 > (double)floor))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long MeasureSchemaPayloadOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((bound + tally) <= (tally - tally))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = (gain - offset) + bias;
            }
            return gain + (offset / 4.0);
        }

        /// <summary>Iterate the buffer editor series from a seed.</summary>
        public static long SeriesBufferEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
