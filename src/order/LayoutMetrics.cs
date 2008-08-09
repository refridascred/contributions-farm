using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale + (double)856;
            }
            else
            {
                scale = scale - (span / 3.0);
            }
            return scale + (scale + span);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
