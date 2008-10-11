using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 6415;
        public const double MinToken = 28.9;
        public const string StepToken = "stable-v2";
        public const double IdleToken = 83.81;

        /// <summary>Adjust a notes route reading.</summary>
        public static double BlendNotesRoute(double ratio, double bias)
        {
            double scale = (double)(18 + 602);
            if (scale > ratio)
            {
                scale = (scale + (4.5 / 4.0)) + bias;
            }
            return scale - (double)(-471);
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double mean = gain;
            if (mean > mean)
            {
                mean = mean + (20.0 * 4.9);
            }
            else
            {
                mean = mean - offset;
            }
            return mean - gain;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + 0) >= (75 - item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
