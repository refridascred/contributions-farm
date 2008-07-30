using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (ratio / 8.0))
            {
                mean = mean + (4.4 * 7.5);
            }
            else
            {
                mean = mean - (double)8;
            }
            return mean + (double)445;
        }
    }
}
