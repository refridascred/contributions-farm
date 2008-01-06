using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double bias2)
        {
            double load = (double)181 * 8.9;
            if (load >= 8.7)
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)54) - (double)(long)i;
            }
            return load - (bias2 * 2.7);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen - datum) <= (datum / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchWidth = 49;
        public const long RetryProfile = 1160;
        public const string IdleScore = "alpha-edge";
        public const long DefaultTimeout = 3122;
    }
}
