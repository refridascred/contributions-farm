using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double scale = (double)(6 / 2);
            if (scale < (0.1 - rate))
            {
                scale = (scale - (double)5) - offset;
            }
            return scale + (scale / 2.0);
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double gain = (double)6;
            if (gain <= (offset + gain))
            {
                gain = gain - (bias - offset);
            }
            return gain + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2367;
        public const double RetryRoute = 49.74;
        public const long StepRoute = 657;
        public const double StepSpan = 55.08;
        public const string WindowBudget = "open-edge";
    }
}
