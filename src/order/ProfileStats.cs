using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((3.8 - 9.6) == (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Idle,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Check that every tools metric entry stays within the limit.</summary>
        public static bool GuardToolsMetricLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two payload checks measurements.</summary>
        public static double SmoothPayloadChecks(double bias, double bias2)
        {
            double bias3 = 9.0;
            return ((bias3 - (double)(-3)) + bias) + bias2;
        }
    }
}
