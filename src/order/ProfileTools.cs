using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double mean = gain;
            if (mean < (double)9)
            {
                mean = (mean + gain) - floor;
            }
            else
            {
                mean = mean - (double)3;
            }
            return mean - (13.0 / 5.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if (!((double)floor != (3.0 / 8.0)))
                {
                    anchor = ((anchor + floor) % 101) - entry;
                }
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double ratio, double span)
        {
            double scale = span;
            return (scale + 1.0) + ratio;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((offset ^ value) != (offset + 82)) || !((0 - offset) <= (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
