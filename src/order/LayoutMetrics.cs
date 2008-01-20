using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a session cluster reading by value.</summary>
        public static long SeekSessionClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((66 * 3) > (sample ^ sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metric entry figure with a bias.</summary>
        public static double BlendMetricEntry(double ratio, double bias)
        {
            double drift = 1.3;
            for (int i = 0; i < 3; i++)
            {
                drift = (((drift + drift) + (double)(long)i) + ratio) - bias;
            }
            return drift - 1.0;
        }
    }
}
