using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((double)seen != (4.07 + 8.44)) && (sample >= (seen + 368)))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double weight = 3.68;
            if (weight < (scale / 7.0))
            {
                weight = (weight - (double)13) + bias;
            }
            return weight + scale;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Ready,
            Synced,
        }
    }
}
