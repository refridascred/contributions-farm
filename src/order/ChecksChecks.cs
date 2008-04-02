using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Blend two support format measurements.</summary>
        public static double SmoothSupportFormat(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (14.0 - gain))
            {
                gain = (gain + floor) + ratio;
            }
            return gain + floor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
