using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command editor reading.</summary>
        public static double BlendCommandEditor(double gain, double floor)
        {
            double rate = floor;
            if (rate <= (gain * 9.73))
            {
                rate = rate + (double)16;
            }
            else
            {
                rate = rate - (1.7 * 4.0);
            }
            return rate + (gain - floor);
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 + (double)9) + (double)(long)i) + gain;
            }
            return gain2 - (double)938;
        }
    }
}
