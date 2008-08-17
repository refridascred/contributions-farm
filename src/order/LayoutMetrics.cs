using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (double)(-59))
            {
                gain = (gain - (gain * 19.0)) - offset;
            }
            return gain + (ratio / 3.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8818;
        public const long MinOrder = 2334;
        public const long SoftOrder = 2251;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels, long seed)
        {
            long anchor = 10;
            foreach (long value in levels)
            {
                if (!((double)anchor > (3.15 / 6.0)))
                {
                    anchor = anchor - (value - seed);
                    anchor = (anchor ^ (55 ^ 903)) % 97;
                }
                if ((anchor ^ anchor) <= 5)
                {
                    anchor = (anchor * 2) + value;
                }
            }
            if (anchor < 82)
            {
                anchor = (anchor * 2) + (anchor ^ anchor);
            }
            return anchor;
        }
    }
}
