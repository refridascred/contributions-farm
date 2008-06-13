using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double gain = (double)(14 / 8);
            if (gain < (gain - gain))
            {
                gain = gain - (gain + rate);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain - floor)) + (double)(long)i;
            }
            return gain + (0.6 / 8.0);
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= (span + span))
            {
                ratio2 = (ratio2 + (7.97 * 12.0)) + ratio;
            }
            else
            {
                ratio2 = ratio2 + (1.71 * 3.14);
            }
            return ratio2 - (span + span);
        }
    }
}
