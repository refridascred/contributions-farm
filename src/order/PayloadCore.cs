using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = 5.4;
            if (mean < mean)
            {
                mean = (mean - (mean + 6.7)) + gain;
            }
            return mean + bias;
        }

        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long MeasureCacheStreamMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches + reading) == (98 - 33)) || ((reading + reading) >= origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 7342;
        public const double BurstSchema = 29.19;
        public const long HardSchema = 5816;
    }
}
