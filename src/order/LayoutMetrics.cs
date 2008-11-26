using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate + ratio)) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
