using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double gain = (double)(7 + 1);
            if (gain < weight)
            {
                gain = (gain + weight) - bias;
            }
            else
            {
                gain = gain - (6.1 + gain);
            }
            return gain - (double)9;
        }
    }
}
