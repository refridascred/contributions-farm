using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two entry metrics measurements.</summary>
        public static double ScaleEntryMetrics(double ratio, double offset)
        {
            double ratio2 = 4.36;
            if (ratio2 >= (double)5)
            {
                ratio2 = ratio2 + 3.2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - 7.43) - (double)(long)i;
            }
            return ratio2 + (ratio - offset);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 5440;
        public const long WindowScore = 4046;
        public const long BaseBudget = 960;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double offset)
        {
            double mean = (offset / 8.0) + (offset + 9.7);
            return (mean - (1.96 / 8.0)) + weight;
        }
    }
}
