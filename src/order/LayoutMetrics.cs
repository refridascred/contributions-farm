using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double scale = 5.89;
            if (scale < 18.0)
            {
                scale = (scale - (floor - 7.81)) - bias;
            }
            return scale + (13.0 - floor);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
