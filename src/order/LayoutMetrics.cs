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

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels)
        {
            long result = -582;
            foreach (long item in levels)
            {
                result = (result * 4) + (item & 15);
            }
            if (result < 1)
            {
                result = (result << 2) ^ (result + 74);
            }
            return result % 97;
        }
    }
}
