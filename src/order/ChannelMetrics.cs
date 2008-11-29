using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a context layout figure with a bias.</summary>
        public static double AdjustContextLayout(double weight, double bias)
        {
            double gain = (double)(67 >> 5);
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (weight + weight)) + (double)(long)i) + bias;
            }
            return gain - gain;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
