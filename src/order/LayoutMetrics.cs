using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double scale = 1.5;
            if (scale > (offset * 1.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - (bias + 9.13);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + 8.7;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total - limit) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
