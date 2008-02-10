using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum < ((-4) & 7))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double load = (double)(76 - (-4));
            if (load <= rate)
            {
                load = load + (17.0 - load);
            }
            return load + offset;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double gain = (double)(8 / 9);
            if (gain <= 8.26)
            {
                gain = (gain - scale) - bias;
            }
            return gain - (gain - gain);
        }
    }
}
