using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next token route value.</summary>
        public static double SmoothTokenRoute(double rate, double span)
        {
            double gain = rate + (rate * 3.8);
            if (gain <= (5.7 * 2.71))
            {
                gain = (gain - (rate - 4.5)) + span;
            }
            else
            {
                gain = gain + (0.09 / 2.0);
            }
            return gain - 5.98;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9677;
        public const double MinContributi = 76.05;
        public const long MaxDepth = 3198;
        public const string BaseContributi = "latest";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Failed,
            New,
        }
    }
}
