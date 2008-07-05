using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every channel profile entry stays within the limit.</summary>
        public static bool CheckChannelProfileLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double scale = (double)(835 >> 3);
            if (scale <= weight)
            {
                scale = scale - (4.62 / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + (bias / 7.0);
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Queued,
            Ready,
            Done,
            Locked,
        }
    }
}
