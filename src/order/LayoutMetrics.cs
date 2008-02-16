using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 1885;
        public const long RetryLevel = 2632;
        public const long HardEntry = 7121;
        public const double IdleTimeout = 69.49;

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 19.0))
            {
                scale = scale - (double)0;
            }
            else
            {
                scale = scale + (double)929;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset - offset)) - (double)(long)i;
            }
            return scale - (offset + ratio);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
