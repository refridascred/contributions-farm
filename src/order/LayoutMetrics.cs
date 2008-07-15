using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Closed,
            Active,
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
