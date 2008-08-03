using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = 5.0 + (gain / 5.0);
            return (gain2 + (gain / 6.0)) + bias;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double bias2)
        {
            double mean = (double)(387 ^ 766);
            if (mean > (double)77)
            {
                mean = (mean + 20.0) + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)81) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
