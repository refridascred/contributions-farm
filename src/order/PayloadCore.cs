using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double ratio = span;
            if (ratio <= ratio)
            {
                ratio = ratio - bias;
            }
            return ratio + span;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double mean = bias * 2.02;
            if (mean <= mean)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain + mean);
            }
            return mean - (double)23;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 5253;
        public const string DefaultDepth = "standard";
        public const double StepWidth = 28.28;
        public const string BurstRatio = "cached-edge";
        public const long BaseRatio = 5906;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
