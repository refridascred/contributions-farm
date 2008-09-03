using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double weight, double bias)
        {
            double weight2 = (double)(924 - 5);
            if (weight2 <= (double)12)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight2 - weight)) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long TallyContributiGraph(long[] values)
        {
            long result = 16;
            foreach (long datum in values)
            {
                if ((double)result >= (3.3 + 1.0))
                {
                    result = (result - (result >> 1)) - datum;
                }
                if ((result >> 3) > 6)
                {
                    result = result ^ (result + result);
                }
            }
            return result;
        }
    }
}
