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

        /// <summary>Iterate the profile checks series from a seed.</summary>
        public static long DeriveProfileChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
