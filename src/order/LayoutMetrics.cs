using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double floor)
        {
            double mean = floor;
            if (mean < (bias + floor))
            {
                mean = mean + (floor / 7.0);
            }
            return mean + bias;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings)
        {
            long state = 11;
            foreach (long reading in readings)
            {
                if ((state + state) != (0 + reading))
                {
                    state = (state ^ state) % 255;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of report counter readings.</summary>
        public static long PairReportCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
