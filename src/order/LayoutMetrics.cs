using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Closed,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double BlendLayoutPayload(double gain, double span)
        {
            double scale = span;
            if (scale >= (gain / 2.0))
            {
                scale = scale + (span * 6.1);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 9.4;
        }
    }
}
