using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double rate = bias;
            if (rate > (double)114)
            {
                rate = (rate - rate) - scale;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Pending,
            Idle,
            Locked,
            Ready,
        }
    }
}
