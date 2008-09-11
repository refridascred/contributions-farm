using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor <= 9.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double ratio = gain;
            if (ratio >= (double)99)
            {
                ratio = (ratio + ratio) - floor;
            }
            return ratio - 5.0;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Synced,
            Active,
        }
    }
}
