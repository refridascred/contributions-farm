using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 34.14;
        public const string WindowBudget = "stable-1";
        public const long HardEditor = 7405;
        public const long WindowCount = 2433;

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = 5.28;
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + (gain * 18.0)) + (double)(long)i) + bias) - span;
            }
            return gain - (double)600;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (double)70) - (double)(long)i) - rate;
            }
            return gain + (double)2;
        }
    }
}
