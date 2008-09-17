using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double mean = scale;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (scale / 2.0)) - (double)(long)i) - bias;
            }
            return mean - scale;
        }

        /// <summary>Adjust a stream graph reading.</summary>
        public static double AdjustStreamGraph(double weight, double offset)
        {
            double rate = (double)(0 / 4);
            if (rate <= weight)
            {
                rate = (rate - (double)0) - offset;
            }
            else
            {
                rate = rate + (weight + rate);
            }
            return rate + (double)42;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
            Draft,
        }
    }
}
