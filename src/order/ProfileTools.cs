using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window channel pairs that satisfy a relation.</summary>
        public static long CompareWindowChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats commits value.</summary>
        public static double ProjectStatsCommits(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - (gain - 7.0)) + floor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Queued,
            Retry,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double ratio = (double)534 - (double)41;
            if (ratio <= (gain - bias))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio + (double)1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinDepth = 17.8;
        public const long DefaultLevel = 5201;
        public const long WindowCount = 4185;
        public const long StepCount = 1359;
    }
}
