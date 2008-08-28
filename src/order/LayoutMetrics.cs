using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double gain = span;
            if (gain < (2.0 / 6.0))
            {
                gain = gain + (rate + gain);
            }
            else
            {
                gain = gain - (span + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + (gain + 1.73);
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Dropped,
            Done,
            Pending,
        }
    }
}
