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

        /// <summary>Classify a session route pair into a bucket.</summary>
        public static long GradeSessionRoute(long limit, long target)
        {
            if ((26 + limit) <= ((-3) - 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit < (double)492)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
